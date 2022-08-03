using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class ViewPools : IViewPools
    {
        private Dictionary<string, ObjectPool> _viewShelf;

        public ViewPools()
        {
            _viewShelf = new Dictionary<string, ObjectPool>();
        }


        public GameObject Create(GameObject prefab)
        {
            if(!_viewShelf.TryGetValue(prefab.name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewShelf[prefab.name] = viewPool;
            }

            return viewPool.Pop();
        }

        public void Destroy(GameObject gameObject)
        {
            _viewShelf[gameObject.name].Push(gameObject);
        }
    }
}
