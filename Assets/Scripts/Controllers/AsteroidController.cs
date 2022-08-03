using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidController
    {

        private float _maxHp;
        private float _speed;
        private float _rotation;

        Health _health;

        AsteroidView _asteroidView;
        Rigidbody _rigidbody;
        Movement _move;


        public AsteroidController(AsteroidView asteroidView, float maxHp, float speed, float rotation)
        {
            _asteroidView = asteroidView;
            _rigidbody = asteroidView.Rigidbody;
            _maxHp = maxHp;
            _speed = speed;
            _rotation = rotation;

            _health = new Health(_maxHp, _maxHp);

            _move = new Movement(_rigidbody);

            new AsteroidRotator(_rigidbody).Rotate(_rotation);
        }

        public void Update()
        {
            _move.Move(-1, 0, _speed, ForceMode.Force);
        }
    }
}
