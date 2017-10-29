using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMove : MonoBehaviour
{
    [SerializeField]
    public Transform CursorPosition;
    public Transform PlayerPosition;
    public float f = 0.5f;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp (CursorPosition.position, PlayerPosition.position,f);        
    }
}