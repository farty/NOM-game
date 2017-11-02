using System;
using UnityEngine;

namespace Assets.Scrypts.ControlledCharacter
{
    class ControledCharacterController : MonoBehaviour, IControlable
    {

        public void Movement(float speed, Vector3 location, Transform transform)
        {
            transform.Translate(location * speed * Time.deltaTime, Space.World);
        }

        public void Rotate(float speed, Vector3 orientation, Quaternion quaternion)
        {
            quaternion = Quaternion.Slerp(quaternion, Quaternion.LookRotation(orientation.normalized), speed);
        }
    }
}
