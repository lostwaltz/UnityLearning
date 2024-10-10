using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerTopDownController : TopDownController
{
    Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnMove(InputValue inputValue)
    {
        OnCallMove(inputValue.Get<Vector2>());
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 worldMousePoistion = mainCamera.ScreenToWorldPoint(inputValue.Get<Vector2>());

        Vector2 mouseDirection = (worldMousePoistion - (Vector2)transform.position).normalized;

        OnCallLook(mouseDirection);
    }
}
