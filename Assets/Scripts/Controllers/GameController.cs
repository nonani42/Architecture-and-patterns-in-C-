using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] Transform[] spawnPoints;
        [SerializeField] PlayerView player;
        Reference _reference;
        IViewPools _ammoPool;
        AsteroidFactory _factory;
        PlayerController _playerController;
        List<AsteroidController> _enemies = new List<AsteroidController>();

        void Awake()
        {
            _reference = new Reference();
            _ammoPool = new ViewPools();
            _factory = new AsteroidFactory(_reference);

            _playerController = new PlayerController(player, _ammoPool);

            for (int i = spawnPoints.Length-1; i >= 0; i--)
            {
                _enemies.Add(_factory.CreateMedium(spawnPoints[i]));
                _enemies.Add(_factory.CreateLarge(spawnPoints[i]));
                _enemies.Add(_factory.CreateCustom(_reference.MediumAsteroid, spawnPoints[i], speed:150f, rotation:2f));
                _enemies.Add(_factory.CreateSmall(spawnPoints[i]));
            }
        }

        void Update()
        {
            _playerController.Update();
            foreach(var enemy in _enemies)
            {
                enemy.Update();
            }
        }
    }
}
