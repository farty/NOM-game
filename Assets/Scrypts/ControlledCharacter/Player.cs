using Assets.Scrypts.ControlledCharacter;
using UnityEngine;
using System;

public class Player : Photon.MonoBehaviour {

    ControledCharacterModel model;
    ControledCharacterController controller;
    Single x, z;

	void Start () {
        model = new ControledCharacterModel(gameObject, PlayerPrefs.GetString("Username"));
        controller = new ControledCharacterController();
	}
	


    void FixedUpdate()
    {
		if (photonView.isMine) {//добавлено раздельное управление персонажами
			x = Input.GetAxisRaw ("Horizontal");
			z = Input.GetAxisRaw ("Vertical");
			controller.Movement (model.MovementSpeed, new Vector3 (x, 0, z), transform);
			controller.Rotate (model.RotationSpeed, new Vector3 (x, 0, z), transform.rotation);
		}
	}
	void OnPhotonSerializeViev(PhotonStream stream, PhotonMessageInfo info)
	{
		Vector3 pos = transform.position;
		Quaternion rot = transform.rotation;
		stream.Serialize(ref pos);
		stream.Serialize(ref rot);
		if (stream.isReading)
		{
			transform.position = pos;
			transform.rotation = rot;
		}
	}

}
