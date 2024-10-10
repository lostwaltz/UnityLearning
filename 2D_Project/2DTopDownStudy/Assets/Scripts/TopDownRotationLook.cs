using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownRotationLook : MonoBehaviour
{
    private TopDownController controller;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();

        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        controller.OnLookEvent += FlipSprite;
    }

    private void FlipSprite(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        spriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    void Update()
    {
        
    }
}
