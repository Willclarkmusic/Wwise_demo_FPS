using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    private bool _isCausingDamage = false;
    public float damageRepeatRate = 0.1f;
    public int damageAmount = 10;
    public bool Repeating = true;

    private void OnTriggerEnter(Collider other)
    {
        _isCausingDamage = true;
        PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
        if (player != null )
        {
            if (Repeating)
            {
                StartCoroutine(playerTakeDamage(player, damageRepeatRate));
            }
            else
            {
                player.playerTakeDamage(damageAmount);
            }
        }
    }

    IEnumerator playerTakeDamage(PlayerHealth player, float repeatRate)
    {
        while (_isCausingDamage)
        {
            player.playerTakeDamage(damageAmount);
            playerTakeDamage(player, repeatRate);
            yield return new WaitForSeconds(repeatRate);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
        if (player != null)
        {
            _isCausingDamage = false;
        }
    }
}
