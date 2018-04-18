using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    public void Move(Vector3 vec)
    {
        velocity = vec;
    }

    void PerformMovement()
    {
        if (!Input.anyKey)
        {
            velocity = Vector3.zero;
        }

        rb.velocity = Vector3.zero;
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }

	
	// Update is called once per frame
	void Update ()
    {
        PerformMovement();
	}
}
