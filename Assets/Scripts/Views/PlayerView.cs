using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private float _health = 10f;

        [SerializeField] private Transform _weaponPoint;


        private Transform _transform;
        private Rigidbody _rigidbody;

        public float Speed { get => _speed; set => _speed = value; }
        public float Health { get => _health; set => _health = value; }
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