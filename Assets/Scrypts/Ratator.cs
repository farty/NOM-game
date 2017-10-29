using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratator : MonoBehaviour
{
    public float rSpeed = 0.3f;

	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), rSpeed);
        }
    }
}
