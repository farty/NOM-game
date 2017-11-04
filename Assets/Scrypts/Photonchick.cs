using System.Collections;
using UnityEngine;

public class Photonchick : Photon.MonoBehaviour {

    void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1");
	}
	
    void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("testRoom", new RoomOptions(), TypedLobby.Default);
    }
    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player", Vector3.up * 5f, Quaternion.identity, 0);
    }
}
