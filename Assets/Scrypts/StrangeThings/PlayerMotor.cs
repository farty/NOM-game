using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour {
    GameObject Obj;

    private Rigidbody rb;
    private Vector3 velocity = Vector3.zero;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    private void FixedUpdate()
    {
        PerformMove();
    }

    void PerformMove()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
        
    }

    public void Move (Vector3 _velocity)
    {
        velocity = _velocity;
    }
}
//MyWorkingScrypt