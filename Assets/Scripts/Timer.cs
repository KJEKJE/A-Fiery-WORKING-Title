﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour

{
    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;
    private void Start()
    {
        if (repeat)
        {
            InvokeRepeating("OnTimerComplete", 0, time);
        }
        else
        {
            Invoke("OnTimerComplete", time);
        }
    }
    private void OnTimerComplete()
    {
        onTimerComplete.Invoke(); //i'm watching you ¬_¬
    }
}
