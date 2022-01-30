using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossBall : MonoBehaviour
{
    public float TossForce = 100f;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * TossForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
