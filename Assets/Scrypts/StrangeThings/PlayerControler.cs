using UnityEngine;

[RequireComponent(typeof (PlayerMotor))]
public class PlayerControler : MonoBehaviour {
    [SerializeField]
    float speed = 3f;

    private PlayerMotor motor;

    void Start () {
        motor = GetComponent<PlayerMotor>();
            
    }
	
	void FixedUpdate () { 
        var xMov = Input.GetAxisRaw("Horizontal");
        var zMov = Input.GetAxisRaw("Vertical");

        var MovHor = transform.right*xMov;
        var MovVert = transform.forward*zMov;
        var velocity = ((MovHor+MovVert).normalized*speed);

        motor.Move(velocity);

	}
}//MyWorkingScrypt
