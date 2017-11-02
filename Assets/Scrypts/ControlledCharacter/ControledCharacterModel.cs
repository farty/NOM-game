using UnityEngine;

namespace Assets.Scrypts.ControlledCharacter
{
    class ControledCharacterModel
    {
        GameObject _prefab;
        Vector3 _coordinates;
        string _controlingPlayer;
        float _movementSpeed = 5f;
        float _rotationSpeed = 0.3f;

        public GameObject Prefab
        {
            get
            {
                return _prefab;
            }

            set
            {
                _prefab = value;
            }
        }
        public Vector3 Coordinates
        {
            get
            {
                return _coordinates;
            }

            set
            {
                _coordinates = value;
            }
        }
        public float MovementSpeed
        {
            get
            {
                return _movementSpeed;
            }

            set
            {
                _movementSpeed = value;
            }
        }
        public float RotationSpeed
        {
            get
            {
                return _rotationSpeed;
            }

            set
            {
                _rotationSpeed = value;
            }
        }
        public string ControlingPlayer
        {
            get
            {
                return _controlingPlayer;
            }

            set
            {
                _controlingPlayer = value;
            }
        }

        public ControledCharacterModel(GameObject prefab, string controlingPlayer)
        {
            _prefab = prefab;
            _controlingPlayer = controlingPlayer;
        }
    }
}
