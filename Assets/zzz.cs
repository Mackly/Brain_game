﻿using UnityEngine;
using System.Collections;

public class zzz : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) 
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
