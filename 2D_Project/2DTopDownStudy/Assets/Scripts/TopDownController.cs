using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    protected void OnCallMove(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    protected void OnCallLook(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
