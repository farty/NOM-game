using System;
using UnityEngine;

namespace Assets.Scrypts.ControlledCharacter
{
    public interface IControlable
    {
        void Movement(float speed, Vector3 location, Transform transform);
        void Rotate(float speead, Vector3 orientation, Quaternion quaternion);
    }
}
