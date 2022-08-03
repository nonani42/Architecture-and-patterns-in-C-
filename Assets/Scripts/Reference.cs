using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Reference
    {
        private GameObject _smallAsteroid;
        private GameObject _mediumAsteroid;
        private GameObject _largeAsteroid;



        public GameObject SmallAsteroid
        {
            get
            {
                if (_smallAsteroid == null)
                {
                    _smallAsteroid = Resources.Load<GameObject>("SmallAsteroid");
                }
                return _smallAsteroid;
            }
        }

        public GameObject MediumAsteroid
        {
            get
            {
                if (_mediumAsteroid == null)
                {
                    _mediumAsteroid = Resources.Load<GameObject>("MediumAsteroid");
                }
                return _mediumAsteroid;
            }
        }

        public GameObject LargeAsteroid
        {
            get
            {
                if (_largeAsteroid == null)
                {
                    _largeAsteroid = Resources.Load<GameObject>("LargeAsteroid");
                }
                return _largeAsteroid;
            }
        }

    }
}
