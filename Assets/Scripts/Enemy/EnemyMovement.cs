using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    [SerializeField]
    private float RotationSpeed;

    private Rigidbody2D rigidbody2d;
    private PlayerAwarnessController _playerAwarnessController;
    private Vector2 targetDirection;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        _playerAwarnessController = GetComponent<PlayerAwarnessController>();
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotationTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection() 
    {
        if (_playerAwarnessController.AwarnessOfPlayer)
        {
            targetDirection = _playerAwarnessController.DirectionOfPlayer;
        }
        else 
        {
            targetDirection = Vector2.zero;
        }
    }

    private void RotationTowardsTarget()
    {
        if (targetDirection == Vector2.zero) 
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);

        rigidbody2d.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        if (targetDirection == Vector2.zero)
        {
            rigidbody2d.velocity = Vector2.zero;
        }
        else
        {
            rigidbody2d.velocity = transform.up * Speed;
        }
    }
}
