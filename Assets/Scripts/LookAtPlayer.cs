using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform playerCam;

    void LateUpdate()
    {
        transform.LookAt(playerCam);
    }
}
