using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class FlappyBirdMovement : MonoBehaviour
    {
        [SerializeField] private float _lauchForce;

        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            TryGetComponent(out _rigidbody2D);
        }

        // Function called by InputSystem
        public void Jump()
        {
            _rigidbody2D.velocity = Vector2.one;
            _rigidbody2D.AddForce(Vector2.up * _lauchForce, ForceMode2D.Impulse);
        }
    }
}
