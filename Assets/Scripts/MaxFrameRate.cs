﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxFrameRate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
