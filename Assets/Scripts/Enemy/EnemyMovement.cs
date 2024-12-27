using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    [SerializeField]
    private float RotationSpeed;

    private Rigidbody2D rigidbody2d;
    private PlayerAwarnessController _playerAwarnessController;
    private Vector2 targetDirection;
    private float ChangeDirectionCooldown;


    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        _playerAwarnessController = GetComponent<PlayerAwarnessController>();
        targetDirection = transform.up;
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotationTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection() 
    {
        EnemyRndomDirectionChange();
        PlayerTargeting();
    }

    private void EnemyRndomDirectionChange()
    {
        ChangeDirectionCooldown -= Time.deltaTime;

        if (ChangeDirectionCooldown <= 0)
        {
            float angleChange = UnityEngine.Random.Range(-90f, 90f); 
            Quaternion rotaion = Quaternion.AngleAxis(angleChange, transform.forward);  
            targetDirection = rotaion * targetDirection;

            ChangeDirectionCooldown = UnityEngine.Random.Range(0f, 2f);
        }
    }

    private void PlayerTargeting() 
    {
        if (_playerAwarnessController.AwarnessOfPlayer)
        {
            targetDirection = _playerAwarnessController.DirectionOfPlayer;
        }
    }

    private void RotationTowardsTarget()
    {

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);

        rigidbody2d.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        rigidbody2d.velocity = transform.up * Speed;
    }
}
