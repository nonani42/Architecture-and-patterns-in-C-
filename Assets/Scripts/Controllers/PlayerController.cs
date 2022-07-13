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
        Movement _move;
        Shooting _shoot;
        IWeapon _weapon;

        Vector3 _direction;


        Vector3 _screenTopLeft;
        Vector3 _screenBottomRight;

        float _speed;

        public PlayerController(PlayerView player)
        {
            _player = player;
            _rigidbody = _player.Rigidbody;
            _transform = _player.Transform;
            _weaponPoint = _player.WeaponPoint;
            _speed = _player.Speed;

            _weapon = new SimpleGun();

            _move = new Movement(_rigidbody);
            _shoot = new Shooting(_weapon);


            _screenTopLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, 10f));
            _screenBottomRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 10f));


        }

        public void Update()
        {

            if (_rigidbody)
            {
                _move.Clamp(_transform, _screenTopLeft.x, _screenBottomRight.x, _screenBottomRight.y, _screenTopLeft.y);
                _move.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), _speed);
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _direction = Vector3.right;
                _shoot.Fire(_weaponPoint, _direction);
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                _shoot.ChangeWeapon();
            }
        }

    }
}
