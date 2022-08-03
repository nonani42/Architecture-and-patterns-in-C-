using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController
    {
        PlayerView _player;
        Transform _transform;
        Transform _weaponPoint;
        Rigidbody _rigidbody;
        Health _health;
        Movement _move;
        Shooting _shoot;
        IWeapon _weapon;

        Vector3 _direction;


        Vector3 _screenTopLeft;
        Vector3 _screenBottomRight;

        float _speed;
        float _maxHealth;


        string _inputVert = "Vertical";
        string _inputHorizont = "Horizontal";
        string _mainFire = "Fire1";
        KeyCode _changeWeapon = KeyCode.G;



        public PlayerController(PlayerView player, IViewPools viewPools)
        {
            _player = player;
            _rigidbody = _player.Rigidbody ? _player.Rigidbody : _player.gameObject.AddComponent<Rigidbody>();
            _transform = _player.Transform;
            _weaponPoint = _player.WeaponPoint;
            _speed = 1f;
            _maxHealth = 10f;

            _weapon = new SimpleGun(viewPools);
            _move = new Movement(_rigidbody);
            _shoot = new Shooting(_weapon);
            _health = new Health(_maxHealth, _maxHealth);


            _screenTopLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, 10f));
            _screenBottomRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 10f));


        }

        public void Update()
        {
            if (!_rigidbody)
            {
                Debug.LogError("No RigidBody!");
            }

            _move.Move(Input.GetAxis(_inputHorizont), Input.GetAxis(_inputVert), _speed);
            _move.Clamp(_transform, _screenTopLeft.x, _screenBottomRight.x, _screenBottomRight.y, _screenTopLeft.y);

            if (Input.GetButtonDown(_mainFire))
            {
                _direction = Vector3.right;
                _shoot.Fire(_weaponPoint, _direction);
            }

            if (Input.GetKeyDown(_changeWeapon))
            {
                _shoot.ChangeWeapon();
            }
        }

    }
}
