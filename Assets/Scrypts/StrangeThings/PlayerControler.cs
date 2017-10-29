using System.Collections;
using System.Collections.Generic;
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
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 MovHor = transform.right*xMov;
        Vector3 MovVert = transform.forward*zMov;
        Vector3 velocity = ((MovHor+MovVert).normalized*speed);

        motor.Move(velocity);

	}
}//MyWorkingScrypt
