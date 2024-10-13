using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CheackValue : MonoBehaviour
{
    public TMP_InputField InputField;

    public int minValue;
    public int maxValue;

    public UnityEvent invokeEvent;

    public void CheackInvokeTextLenght()
    {
        if(minValue <= InputField.text.Length && maxValue >= InputField.text.Length )
        {
            invokeEvent?.Invoke();
        }
    }
}
