using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun_01 : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField] private GameObject _bullet_01;
    [SerializeField] private GameObject bulletPointPrim;
    [SerializeField] private GameObject bulletPointSec;
    [SerializeField] private float bulletSpeedPrim = 600f;
    public int _primaryAmmoCount;
    public int _secondaryAmmoCount;
    private Player_Audio playerAudio;
    private Animator _animator;
    private PauseMenu menuSystem;



    void Start()
    {
        menuSystem = GetComponentInParent<PauseMenu>();
        _animator = GetComponentInParent<Animator>();
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {

        if (menuSystem.GameIsPaused == false)
        {
            if (_input.ShootPrimary)
            {
                ShootPrimary();
                _input.ShootPrimary = false;
            }
        }
    }

    void ShootPrimary()
    {
        _animator.SetTrigger("shootPrimary");
        GameObject bullet = Instantiate(_bullet_01, bulletPointPrim.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeedPrim);
        Destroy(bullet, 1);

    }

    void ShootSecondary()
    {
        Debug.Log("ShootSecondary!");
    }
}
