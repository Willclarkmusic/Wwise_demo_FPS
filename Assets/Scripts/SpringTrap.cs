using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class SpringTrap : MonoBehaviour
{
    public GameObject FireTrap;
    public AK.Wwise.Event FireSound;
    // Start is called before the first frame update
    private float Timer = 0;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FireSound.Post(gameObject);
            FireTrap.SetActive(true);
        }

    }

    // Update is called once per frame

}
