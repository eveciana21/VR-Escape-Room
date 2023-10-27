using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    private bool _timerActive = true;
    private float _currentTime;
    [SerializeField] private TMP_Text _text;

    void Start()
    {
        _currentTime = 0;
    }

    void Update()
    {
        if (_timerActive)
        {
            _currentTime = _currentTime + Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(_currentTime);
        _text.text = time.Minutes.ToString() + " : " + time.Seconds.ToString() + " : " + time.Milliseconds.ToString();
    }

    public void StartTimer()
    {
        _timerActive = true;
    }
    public void StopTimer()
    {
        _timerActive = false;
    }
}
