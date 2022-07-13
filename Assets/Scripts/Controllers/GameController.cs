using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] PlayerView player;
        PlayerController _playerController;

        void Awake()
        {
            _playerController = new PlayerController(player);
        }

        void Update()
        {
            _playerController.Update();
        }
    }
}
