using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class SimpleGun : IWeapon
    {
        IViewPools _viewPools;

        GameObject _simpleGunPrefab;
        GameObject _ammo;
        Rigidbody _rigidbody;

        float _speed = 7f;

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
        }

        public SimpleGun(IViewPools viewPools)
        {
            _viewPools = viewPools;
        }


        public void Fire(Transform point, Vector3 direction)
        {
            _ammo = _viewPools.Create(SimpleGunPrefab);
            _ammo.transform.position = point.position;
            _rigidbody = _ammo.GetComponent<Rigidbody>();
            _rigidbody.AddForce(direction * _speed, ForceMode.Impulse);
            _viewPools.Destroy(_ammo); //destroys immediately, needs an update to set timer or check for out of view
        }
    }
}
