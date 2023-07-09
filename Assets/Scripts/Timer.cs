﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Image timer;
    public float timeLimit = 60f;
    [SerializeField]
    public ScriptReader scriptReader;

    float time;
    bool startTimer;
    float multiplierFactor;
    // Start is called before the first frame update
    void Start()
    {
        time = 60f;
        multiplierFactor = 1f / timeLimit;
        timer.fillAmount = time * multiplierFactor;
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startTimer) {
            return;
        }

        if (time > 0f)
        {
            timer.fillAmount = time * multiplierFactor;
            time -= Time.deltaTime;
        } 
        else 
        {
            scriptReader.UpdateNextScript();
            time = 60f;
        }
    }

}