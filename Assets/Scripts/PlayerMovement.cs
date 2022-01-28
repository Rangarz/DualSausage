using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode ForwardKey;
    public KeyCode BackwardKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;

    public float MoveSpeed;

    private Rigidbody rigidbody;
    private Vector3 moveDirection;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveDirection = Vector3.zero;

        if(Input.GetKey(ForwardKey))
        {
            moveDirection.x += -1;
        }

        if (Input.GetKey(BackwardKey))
        {
            moveDirection.x += 1;
        }

        if(Input.GetKey(LeftKey))
        {
            moveDirection.z += -1;
        }

        if (Input.GetKey(RightKey))
        {
            moveDirection.z += 1;
        }
    }

    private void FixedUpdate()
    {
        if (rigidbody.velocity.x > 20f)
            moveDirection.x = 0f;

        if (rigidbody.velocity.z > 20f)
            moveDirection.z = 0f;


        rigidbody.AddForce(moveDirection * MoveSpeed * Time.fixedDeltaTime);
    }
}
