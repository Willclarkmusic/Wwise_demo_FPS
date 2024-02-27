using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;
    public Slider healthSlider;
    private Player_Audio playerAudio;
    [SerializeField] GameObject deathUI;
    [SerializeField] GameObject winUI;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<Player_Audio>();
        deathUI.SetActive(false);
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = playerHealth;
    }

    public void playerTakeDamage(int amount)
    {
        playerHealth -= amount;
        if (playerHealth <= 0)
        {
            playerHealth = 0;
            dead();
        }
    }

    public void dead() 
    {
        playerAudio.playDeathSound();
        deathUI.SetActive (true);
        Invoke("Reset", 3.0f);
    }

    public void Reset()
    {
        AkSoundEngine.StopAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
