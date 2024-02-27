using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var _player = other.gameObject.GetComponent<PlayerHealth>();
            Debug.Log("dead");
            _player.dead();

        }

    }
}
