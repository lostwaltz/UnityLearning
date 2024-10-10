using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeText : MonoBehaviour
{
    public UIValueHandler uIValueHandler;

    void Update()
    {
        uIValueHandler.SetString(DateTime.Now.ToString("HH:mm:ss"));
    }
}
