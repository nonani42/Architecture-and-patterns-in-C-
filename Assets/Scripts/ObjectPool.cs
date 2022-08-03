using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class ObjectPool : IDisposable
    {
        private Stack<GameObject> _stack = new Stack<GameObject>();
        private GameObject _prefab;
        private Transform _root;

        public ObjectPool(GameObject prefab)
        {
            _prefab = prefab;
            _root = new GameObject($"{prefab.name}").transform;
        }

        public GameObject Pop()
        {
            GameObject gameObject;
            if (_stack.Count == 0)
            {
                gameObject = GameObject.Instantiate(_prefab);
                gameObject.name = _prefab.name;
            }
            else
            {
                gameObject = _stack.Pop();
            }
            gameObject.SetActive(true);
            gameObject.transform.SetParent(null);
            return gameObject;
        }

        public void Push(GameObject gameObject)
        {
            gameObject.SetActive(false);
            gameObject.transform.SetParent(_root);
            _stack.Push(gameObject);
        }

        public void Dispose()
        {
            for (int i = 0; i < _stack.Count; i++)
            {
                GameObject.Destroy(_stack.Pop());
            }
            GameObject.Destroy(_root.gameObject);
        }
    }
}
