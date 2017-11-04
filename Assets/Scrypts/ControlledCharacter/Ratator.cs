using UnityEngine;

public class Ratator : Photon.MonoBehaviour
{
    public float rSpeed = 0.3f;

	void FixedUpdate () {
		if (photonView.isMine) {
			var moveHorizontal = Input.GetAxisRaw ("Horizontal");
			var moveVertical = Input.GetAxisRaw ("Vertical");
			Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
			if (movement != Vector3.zero)
				transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (movement.normalized), rSpeed);
		}
    }

	void OnPhotonSerializeViev(PhotonStream stream, PhotonMessageInfo info)
	{
		Quaternion rot = transform.rotation;
		stream.Serialize (ref rot);
		if (stream.isReading) {
			transform.rotation = rot;
		}
	
	}
}

// не синхронизируется поворот