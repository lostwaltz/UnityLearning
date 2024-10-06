using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera mainCamera;
    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // InputSystem을 통해 트리거 될때 자동으로 호출됨
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // InputSystem을 통해 트리거 될때 자동으로 호출됨
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
    public void OnFire(InputValue value)
    {
        isAttacking = value.isPressed;
    }
}
