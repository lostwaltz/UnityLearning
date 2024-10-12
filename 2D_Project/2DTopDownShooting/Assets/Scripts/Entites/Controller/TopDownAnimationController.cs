﻿using System;
using UnityEngine;

public class TopDownAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isHit = Animator.StringToHash("isHit");
    private static readonly int attack = Animator.StringToHash("attack");

    private readonly float magnituteThreshold = 0.5f;
    private HealthSystem healthSystem;

    protected override void Awake()
    {
        base.Awake();
        healthSystem = GetComponent<HealthSystem>();
    }


    private void Start()
    {

        if (healthSystem != null)
        {
            healthSystem.OnDamage += Hit;
            healthSystem.OninvinciblilityEnd += InvincilbilityEnd;
        }


        controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

    private void Attacking(AttackSO sO)
    {
        animator.SetTrigger(attack);
    }

    private void Hit()
    {
        animator.SetBool(isHit, true);
    }

    private void InvincilbilityEnd()
    {
        animator.SetBool(isHit, false);
    }
}

