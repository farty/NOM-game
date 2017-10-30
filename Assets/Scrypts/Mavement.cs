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
        var moveHorizontal = Input.GetAxisRaw("Horizontal");
        var moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
    }
}