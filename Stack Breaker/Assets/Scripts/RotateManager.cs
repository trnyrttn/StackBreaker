﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateManager : MonoBehaviour
{

    public float speed = 100f; // Hız değişkeni

    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0)); // Rotasyon y eksenine , hız değişkeni ekledik
    }
}
