﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 30;
    private float bottomLimit = -5;

    void Update()
    {
        // Уничтожаем префаб, если он перешёл левые границы
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        }
        // Уничтожаем префаб, если он перешёл нижние границы
        else if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }

    }

}
