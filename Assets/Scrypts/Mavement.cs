using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mavement : MonoBehaviour
{
    public float movementSpeed = 5f;
   

    void FixedUpdate()
    {

        ControllPlayer();
    }


    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
    }
}