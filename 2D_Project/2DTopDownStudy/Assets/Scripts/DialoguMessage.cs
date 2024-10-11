using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialoguMessage : MonoBehaviour
{
    public UnityEvent endDialoguEvent;

    private int messageIndex = 0;
    public List<string> messageContainor;

    public UIValueHandler uIValueHandler;

    private void OnEnable()
    {
        messageIndex = 0;
        SetMassage(0);
    }

    private void Start()
    {
        messageIndex = 0;
        SetMassage(0);
    }


    public void NextMessage()
    {
        messageIndex++;

        if (messageContainor.Count <= messageIndex)
        {
            endDialoguEvent.Invoke();

            return;
        }

        SetMassage(messageIndex);
    }

    private void SetMassage(int index)
    {
        uIValueHandler.SetString(messageContainor[index]);
    }
}
