using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidRotator
    {
        private Rigidbody _rigidbody;

        public AsteroidRotator(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void Rotate(float tumble)
        {
            _rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
        }
    }
}
