using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InterActionPublisher : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnStay;
    public UnityEvent OnExit;

    public List<string> CheckKeyList;
    private SortedSet<string> keyContainer = new SortedSet<string>();

    private void Start()
    {
        foreach (string key in CheckKeyList)
            keyContainer.Add(key);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(true == keyContainer.Contains(collision.gameObject.tag))
        {
            OnEnter.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (true == keyContainer.Contains(collision.gameObject.tag))
        {
            OnStay.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (true == keyContainer.Contains(collision.gameObject.tag))
        {
            OnExit.Invoke();
        }
    }
}
