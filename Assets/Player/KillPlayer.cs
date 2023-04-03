using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]//Look back at recording April 26th 2022
    Transform positionToSendDeadPlayer;

    void OnTriggerEnter(Collider other)//used to respawn players or set check point type things
    {
        if (other.gameObject.CompareTag("Player"))
        {
           //other.gameObject.transform.position = positionToSendDeadPlayer;
        }
    }
}
