using UnityEngine;

public class Ratator : MonoBehaviour
{
    public float rSpeed = 0.3f;

	void Update () {
        var moveHorizontal = Input.GetAxisRaw("Horizontal");
        var moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        if (movement != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), rSpeed);
    }
}
