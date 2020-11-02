﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{

    private GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject cube in cubes){
            cube.transform.Rotate(0, 1, 0);
        }
    }
}
