using UnityEngine;

public class CursorControl : Photon.MonoBehaviour {

	void FixedUpdate () {
		//if (photonView.isMine) {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
			
				transform.position = hit.point;
			//} тоже самое что и с камера мув
		}

    }
}
