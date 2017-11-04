using UnityEngine;
public class CameraMove : Photon.MonoBehaviour
{
    
    public Transform CursorPosition;
    public Transform PlayerPosition;
    public float f = 0.5f;
    private void FixedUpdate()
    {
		if (photonView.isMine) {
			transform.position = Vector3.Lerp (CursorPosition.position, PlayerPosition.position, f);
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

//скрипт работает корректно когда один игрок. Если подключить вторго игрока - пустышка которая двигает камеру привязывается к нему, и наоборот.