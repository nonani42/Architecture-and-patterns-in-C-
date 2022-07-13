using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public interface IWeapon
    {
        public void Fire(Transform point, Vector3 direction);
    }
}
