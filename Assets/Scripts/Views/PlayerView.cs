using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform _weaponPoint;

        private Transform _transform;
        private Rigidbody _rigidbody;

        public Transform WeaponPoint { get => _weaponPoint; set => _weaponPoint = value; }

        public Transform Transform
        {
            get
            {
                if (_transform == null)
                {
                    _transform = GetComponent<Transform>();
                }
                return _transform;
            }
            private set => _transform = value;
        }

        public Rigidbody Rigidbody
        {
            get
            {
                if (_rigidbody == null)
                {
                    TryGetComponent<Rigidbody>(out _rigidbody);
                }
                return _rigidbody;
            }
            private set => _rigidbody = value;
        }

    }
}