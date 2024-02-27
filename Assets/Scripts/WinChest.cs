using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class WinChest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private PauseMenu menuSystem;
    private StarterAssetsInputs _input;
    public AK.Wwise.Event WinGameSound;


    private void Start()
    {
        menuSystem = player.GetComponent<PauseMenu>();
        _input = player.GetComponent<StarterAssetsInputs>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("youcanwin");
            if (_input.Interact)
            {
                WinGame();
            }
        }
    }
    private void WinGame()
    {
        WinGameSound.Post(gameObject);
        Debug.Log("winGame");
        menuSystem.Pause();
        menuSystem.WinTextUI.SetActive(true);
        menuSystem.ResumeButton.SetActive(false);
    }


}
