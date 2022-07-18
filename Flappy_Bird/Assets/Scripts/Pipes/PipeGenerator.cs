using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _pipesPrefabs;
    
    [SerializeField] private float _timerValue;
    private float _timerCouter;
    
    void Update()
    {
        if (_timerCouter > _timerValue)
        {
            Instantiate(_pipesPrefabs[Random.Range(0, _pipesPrefabs.Length)], transform.position, Quaternion.identity);
            _timerCouter = 0f;
        }

        _timerCouter += Time.deltaTime;
    }
}
