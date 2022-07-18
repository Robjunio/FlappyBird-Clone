using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PipeDeath : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                FlappyBirdLifeSystem FlappyBird = col.gameObject.GetComponent<FlappyBirdLifeSystem>();
                FlappyBird.PlayerDie();
            }
        }
    }
}
