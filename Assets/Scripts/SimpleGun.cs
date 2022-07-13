using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class SimpleGun : IWeapon
    {
        GameObject _simpleGunPrefab;
        GameObject _ammo;
        Rigidbody _rigidbody;

        float _speed = 7f;
        float _lifespan = 2f;

        public GameObject SimpleGunPrefab
        {
            get
            {
                if (_simpleGunPrefab == null)
                {
                    _simpleGunPrefab = Resources.Load<GameObject>("SimpleGun");
                }
                return _simpleGunPrefab;
            }
            set => _simpleGunPrefab = value;
        }

        public void Fire(Transform point, Vector3 direction)
        {

            _ammo = GameObject.Instantiate(SimpleGunPrefab, point);
            _ammo.transform.parent = null;
            _rigidbody = _ammo.GetComponent<Rigidbody>();
            _rigidbody.AddForce(direction * _speed, ForceMode.Impulse);
            GameObject.Destroy(_ammo, _lifespan);
        }
    }
}
