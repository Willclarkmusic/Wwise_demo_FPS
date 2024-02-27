using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Audio : MonoBehaviour
{
    public AK.Wwise.Event footstepSoundLeft;
    public AK.Wwise.Event footstepSoundRight;
    public AK.Wwise.Event jumpSound;
    public AK.Wwise.Event landSound;
    public AK.Wwise.Event shootPrimarySound;
    public AK.Wwise.Event deathSound;


    void Start()
    {

    }

    public void playFoostepLeft()
    {
        footstepSoundLeft.Post(gameObject);
    }
    public void playFoostepRight()
    {
        footstepSoundRight.Post(gameObject);
    }

    public void playJumpSound()
    {
        jumpSound.Post(gameObject);
    }
    public void playShootPrimarySound()
    {
        shootPrimarySound.Post(gameObject);
    }
    public void playLandSound()
    {
        landSound.Post(gameObject);
    }

    public void playDeathSound()
    {
        deathSound.Post(gameObject);
    }
}
