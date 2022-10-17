using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEndCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            var respawner = other.GetComponent<Respawn>();
            if(respawner != null)
            {
                respawner.respawn();
            }
        }
    }
}
