using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrimary : MonoBehaviour
{
    public int primaryDamage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dragon")
        {
            Destroy(transform.GetComponent<Rigidbody>());

            other.GetComponent<DragonBehavior>().TakeDamage(primaryDamage);
        }
    }

}
