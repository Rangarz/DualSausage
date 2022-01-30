using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDeath : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        var parentMovement = collision.gameObject.GetComponentInParent<PlayerMovement>();
        var childMovement = collision.gameObject.GetComponentInChildren<PlayerMovement>();

        if(parentMovement != null || childMovement != null)
        {
            
            Debug.Log("DEATH");
        }
    }
}
