using System;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    private TopDownController controller;

    [SerializeField] private Transform projectileSpawnPostion;
    private Vector2 aimDirection = Vector2.right;

    public GameObject Arrow;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnAttackEvent += OnShoot;

        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        aimDirection = direction;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        // TODO :: 투사체 날라가게
        float rotZ = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        Instantiate(Arrow, projectileSpawnPostion.position, Quaternion.Euler(0, 0, rotZ));
    }
}