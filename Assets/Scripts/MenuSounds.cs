using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{

    [SerializeField] GameObject Listener;
    [SerializeField] AK.Wwise.Event ClickSound;
    [SerializeField] AK.Wwise.Event HoverSound;
    // Start is called before the first frame update

    public void playClickSound()
    {
        Debug.Log("Click");
        ClickSound.Post(Listener);
    }
    public void playHoverSound() 
    {
        Debug.Log("Hover");

        HoverSound.Post(Listener);
    }
}
