using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidView : MonoBehaviour
    {
        private Transform _transform;
        private Rigidbody _rigidbody;

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

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("Collision");
            }
        }
    }
}
