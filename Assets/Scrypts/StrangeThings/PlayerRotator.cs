using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField]
    public float speed = 5;

    void FixedUpdate()
    {

        var playerPlane = new Plane(Vector3.up, transform.position);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var hitdist = 0.0f;

        if (!playerPlane.Raycast(ray, out hitdist)) return;
        var targetPoint = ray.GetPoint(hitdist);
        var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
    }
}