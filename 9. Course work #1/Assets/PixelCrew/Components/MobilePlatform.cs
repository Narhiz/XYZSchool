using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{
    public class MobilePlatform : MonoBehaviour
    {
        [SerializeField] private int _speed;

        private Rigidbody2D _rigidbody;
        private int _direction;
        public int xVelocity;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (transform.position.x <= -12)
            {
                _direction = 1;
            }
            if (transform.position.x >= -5)
            {
                _direction = -1;
            }
            xVelocity = _direction * _speed;
			//var yVelocity = _direction * _speed;
			_rigidbody.velocity = new Vector2(xVelocity, 0);
		}
    }
}

