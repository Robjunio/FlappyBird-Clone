using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    private Vector3 initialPosition;

    [SerializeField] private float imageSize;
    [SerializeField] private float speed;

    private void Start()
    {
        initialPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        var desiredPosition = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (desiredPosition.x <= initialPosition.x - imageSize)
        {
            transform.position = initialPosition;
            return;
        }

        transform.position = desiredPosition;
    }
}
