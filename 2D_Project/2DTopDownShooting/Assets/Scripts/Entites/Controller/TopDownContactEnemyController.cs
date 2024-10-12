using System;
using UnityEngine;

public class TopDownContactEnemyController : TopDownEnemyController
{
    [SerializeField][Range(0, 100f)] private float followRange;
    [SerializeField] private string targetTag = "Player";
    private bool isCollidingWithTarget;

    [SerializeField] private SpriteRenderer characterRenderer;

    HealthSystem healthSystem;
    private HealthSystem collidingTargetHealtSystem;
    private TopDownMovement collidingMovement;

    protected override void Start()
    {
        base.Start();

        healthSystem = GetComponent<HealthSystem>();
        healthSystem.OnDamage += OnDamage;
    }

    private void OnDamage()
    {
        followRange = 100f;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (isCollidingWithTarget)
        {
            ApplyHealthChange();
        }

        UpdateEnemyState();
    }
    private void UpdateEnemyState()
    {
        Vector2 direction = Vector2.zero;
        if (DistanceToTraget() < followRange)
        {
            direction = DirectionToTarget();
        }



        CallMoveEvent(direction);
        Rotate(direction);
    }


    private void ApplyHealthChange()
    {
        AttackSO attackSO = characterStatsHandler.CurrentStat.attackSO;
        bool isAttackable = collidingTargetHealtSystem.ChangeHealth(-attackSO.power);

        if(isAttackable && attackSO.isOnKnockBack)
        {
            if(collidingMovement != null)
            {
                collidingMovement.ApplyKnockback(transform, attackSO.power, attackSO.knockbackTime);
            }
        }
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject receiver = collision.gameObject;
        if(!receiver.CompareTag(targetTag))
        {
            return;
        }

        collidingTargetHealtSystem = collision.GetComponent<HealthSystem>();
        if(collidingTargetHealtSystem != null)
        {
            isCollidingWithTarget = true;
        }

        collidingMovement = collision.GetComponent<TopDownMovement>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.CompareTag(targetTag)) { return; }

        isCollidingWithTarget = false;
    }
}

