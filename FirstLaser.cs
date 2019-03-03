﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaser : MonoBehaviour
{

    [SerializeField]
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
