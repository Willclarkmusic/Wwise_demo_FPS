using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonBehavior : MonoBehaviour
{
    private int HP = 100;
    public Slider healthBar;
    public GameObject healthBarCanvas;
    public Animator animator;
    private float damageTimer;
    private Dragon_Audio dragonAudio;
    private bool _isDeadDragon;
    private Collider _winBox;
    [SerializeField] GameObject WinBox;
    
     
    // Start is called before the first frame update
    void Start()
    {
        _winBox = WinBox.GetComponent<Collider>();
        _isDeadDragon = false;
        dragonAudio = GetComponent<Dragon_Audio>();
        AkSoundEngine.SetState("DragonState", "Patrolling");
        damageTimer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        damageTimer -= Time.deltaTime;
        healthBar.value = HP;
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            _isDeadDragon = true;
            AkSoundEngine.SetState("PlayerLocation", "BossDead");
            GetComponent<Collider>().enabled = false;
            healthBarCanvas.SetActive(false);
            dragonAudio.playDeathDragonSound();
            dragonAudio.stopDragonSounds();
            WinBox.SetActive(true);
        }
        else if (HP > 0 && damageTimer <= 0)
        {
            animator.SetTrigger("damage");
            damageTimer = 3;     
        }
    }
}
