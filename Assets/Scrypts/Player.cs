using Assets.Scrypts.ControlledCharacter;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

    ControledCharacterModel model;
    ControledCharacterController controller;
    Single x, z;

	void Start () {
        model = new ControledCharacterModel(gameObject, PlayerPrefs.GetString("Username"));
        controller = new ControledCharacterController();
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        controller.Rotate(model.RotationSpeed, new Vector3(x, 0, z), transform.rotation);
	}

    void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        controller.Movement(model.MovementSpeed, new Vector3(x, 0, z), transform);
    }
}
