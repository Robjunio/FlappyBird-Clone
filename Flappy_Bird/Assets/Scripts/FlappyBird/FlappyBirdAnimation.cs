using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Game
{
    public class FlappyBirdAnimation : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private float _flappyPositionY;

        private void Awake()
        {
            TryGetComponent(out _rigidbody2D);
        }

        private void Start()
        {
            _flappyPositionY = _rigidbody2D.position.y;
            _rigidbody2D.transform.eulerAngles = Vector3.zero;
        }

        private void Update()
        {
            if (math.abs(_flappyPositionY - _rigidbody2D.position.y) == 0)
            {
                return;
            }

            var rotation = _flappyPositionY > _rigidbody2D.position.y ? -1 : 1;

            _rigidbody2D.transform.eulerAngles = new Vector3(0, 0, 45 * rotation);

            _flappyPositionY = _rigidbody2D.position.y;
        }


    }
}
