using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using StarterAssets;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject soundSettingsUI;
    public GameObject WinTextUI;


    private CharacterController _controller;
    private StarterAssetsInputs _input;
    public GameObject ResumeButton;


    private void Start()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        _input = transform.root.GetComponent<StarterAssetsInputs>();

    }

    private void Update()
    {

        if (GameIsPaused)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (!GameIsPaused)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            if (_input.PauseGame)
            {
                Pause();
            }
        }
    }

    public void Restart()
    {
        AkSoundEngine.StopAll();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void soundSettings()
    {
        soundSettingsUI.SetActive(true);
    }
    public void soundSettingsClose()
    {
        soundSettingsUI.SetActive(false);
    }

    public void Resume()
    {
        GameIsPaused = false;
        Debug.Log("unpaused");
    }


    public void Pause()
    {
        GameIsPaused = true;
        Debug.Log("paused");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
