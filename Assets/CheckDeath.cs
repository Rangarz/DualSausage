using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDeath : MonoBehaviour
{
    public bool isDeath = false;
    private void OnCollisionEnter(Collision collision)
    {
        var parentMovement = collision.gameObject.GetComponentInParent<PlayerMovement>();
        var childMovement = collision.gameObject.GetComponentInChildren<PlayerMovement>();

        if(parentMovement != null || childMovement != null)
        {
            isDeath = true;
            Debug.Log("DEATH");
        }
    }


}
