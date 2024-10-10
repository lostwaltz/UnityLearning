using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private Vector2 m_direction = Vector2.zero;

    private TopDownController controller;
    private Rigidbody2D movementRigidbody2D;
    private Animator animator;


    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyDirectionMove();
    }

    private void Move(Vector2 direction)
    {
        m_direction = direction.normalized;
    }

    private void ApplyDirectionMove()
    {
        movementRigidbody2D.velocity = m_direction * 5f;

        animator.SetFloat("Speed", movementRigidbody2D.velocity.magnitude);
    }
}
