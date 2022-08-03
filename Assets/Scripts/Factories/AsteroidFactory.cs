using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidFactory
    {
        private Reference _reference;

        GameObject _prefab;

        Transform _point;
        private float _health;
        private float _speed;
        private float _rotation;


        public AsteroidFactory(Reference reference)
        {
            _reference = reference;
        }

        public AsteroidController Create()
        {
            GameObject _smallAsteroid = GameObject.Instantiate(_prefab, _point);
            return new AsteroidController(_smallAsteroid.GetComponent<AsteroidView>(), _health, _speed, _rotation);
        }

        public AsteroidController CreateSmall(Transform point)
        {
            _prefab = _reference.SmallAsteroid;
            _point = point;
            _health = 10f;
            _speed = 200f;
            _rotation = 1f;
            return Create();
        }

        public AsteroidController CreateMedium(Transform point)
        {
            _prefab = _reference.MediumAsteroid;
            _point = point;
            _health = 20f;
            _speed = 200f;
            _rotation = 0.5f;
            return Create();
        }

        public AsteroidController CreateLarge(Transform point)
        {
            _prefab = _reference.LargeAsteroid;
            _point = point;
            _health = 30f;
            _speed = 200f;
            _rotation = 0.25f;
            return Create();
        }

        public AsteroidController CreateCustom(GameObject prefab, Transform point, float health = 10f, float speed = 200f, float rotation = 1f)
        {
            _prefab = prefab;
            _point = point;
            _health = health;
            _speed = speed;
            _rotation = rotation;
            return Create();
        }

    }
}
