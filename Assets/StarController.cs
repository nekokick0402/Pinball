﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

    private float rotspeed = 1.0f;

    private void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    private void Update()
    {
        this.transform.Rotate(0, this.rotspeed, 0);
    }
}
