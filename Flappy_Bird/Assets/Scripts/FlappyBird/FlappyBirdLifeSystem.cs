using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class FlappyBirdLifeSystem : MonoBehaviour
    {
        public void PlayerDie()
        {
            Time.timeScale = 0f;
            Debug.Log("Você perdeu!");
        }
    }
}

