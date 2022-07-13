using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Movement : IMove
    {
        Rigidbody _rigidbody;
        float _speed;
        Vector3 _direction;

        public Movement(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void Move(float horizontal, float vertical, float speed)
        {
            _speed = speed * Time.fixedDeltaTime;
            _direction = new Vector3(horizontal, vertical);
            _rigidbody.AddForce(_direction * _speed);
        }

        public void Clamp(Transform transform, float xMin, float xMax, float yMin, float yMax)
        {
            float xClamp = Mathf.Clamp(transform.position.x, xMin, xMax);
            float yClamp = Mathf.Clamp(transform.position.y, yMin, yMax);
            transform.position = new Vector3(xClamp, yClamp, transform.position.z);
        }
    }
}
