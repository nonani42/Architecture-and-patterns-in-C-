using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public interface IMove
    {
        public void Move(float horizontal, float vertical, float speed);
    }
}
