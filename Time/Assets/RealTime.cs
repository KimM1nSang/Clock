using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealTime : MonoBehaviour
{
    public Text year;
    public Text month;
    public Text day;
    public Text hour;
    public Text minute;
    public Text second;
    string _year;
    string _month;
    string _day;
    string _hour;
    string _minute;
    string _second;

    private bool isSleep = true;

    void Update()
    {
        _year = DateTime.Now.ToString("yyyy 년");
        _month = DateTime.Now.ToString("MM 월");
        _day =DateTime.Now.ToString("dd 일");
        _hour = DateTime.Now.ToString("HH시");
        _minute = DateTime.Now.ToString("mm분");
        _second = DateTime.Now.ToString("ss초");
        year.text = _year;
        month.text = _month;
        day.text = _day;
        hour.text = _hour;
        minute.text = _minute;
        second.text = _second;
    }

    public void SleepActive()
    {
        if (isSleep)
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            isSleep = false;
        }
        else
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
            isSleep = true;
        }

    }
}
