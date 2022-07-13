using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Shooting
    {
        List<IWeapon> _allWeapons;
        int _currentIndex;
        IWeapon _currentWeapon;

        public IWeapon CurrentWeapon
        {
            get
            {
                if (_currentWeapon == null)
                {
                    _currentWeapon = _allWeapons[_currentIndex];
                }
                return _currentWeapon;
            }
            private set => _currentWeapon = value;
        }

        public Shooting(IWeapon weapon)
        {
            _allWeapons = new List<IWeapon>() { weapon };
            _currentIndex = 0;
        }

        public void Fire(Transform weaponPoint, Vector3 direction)
        {
            CurrentWeapon.Fire(weaponPoint, direction);
        }

        public void ChangeWeapon()
        {
            if (_currentIndex == (_allWeapons.Count - 1))
            {
                _currentIndex = 0;
            }
            _currentIndex++;
        }

        public void AddWeapon(IWeapon weapon)
        {
            if (!_allWeapons.Contains(weapon))
            {
                _allWeapons.Add(weapon);
            }
        }
    }
}
