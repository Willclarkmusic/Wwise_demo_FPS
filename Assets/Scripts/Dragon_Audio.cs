using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Audio : MonoBehaviour
{
    // Start is called before the first frame update

    public AK.Wwise.Event walkFoostepSound;
    public AK.Wwise.Event runFootstepSound;
    public AK.Wwise.Event dragonBaseSounds;
    public AK.Wwise.Event stopDragonBaseSounds;
    public AK.Wwise.Event dragonRageSound;
    public AK.Wwise.Event hitDragonSound;
    public AK.Wwise.Event deathDragonSound;
    public AK.Wwise.Event attackDragonSound;

    // public AK.Wwise.State dragonState;

    void Start()
    {
        playDragonSounds();
    }

    public void playWalkFoostepSound()
    {
        walkFoostepSound.Post(gameObject);
    }

    public void playRunFoostepSound()
    {
        runFootstepSound.Post(gameObject);
    }
    public void playDragonSounds()
    {
        dragonBaseSounds.Post(gameObject);
    }

    public void stopDragonSounds()
    {
        stopDragonBaseSounds.Post(gameObject);
    }

    public void playDragonRageSound()
    {
        dragonRageSound.Post(gameObject);
    }

    public void playGetHitDragonSound()
    {
        hitDragonSound.Post(gameObject);
    }

    public void playDeathDragonSound()
    {
        deathDragonSound.Post(gameObject);
    }

    public void playAttack1Sound()
    {
        attackDragonSound.Post(gameObject);
    }



}
