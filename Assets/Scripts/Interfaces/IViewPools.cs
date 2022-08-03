using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public interface IViewPools
    {
        GameObject Create(GameObject prefab);
        void Destroy(GameObject gameObject);
    }
}
