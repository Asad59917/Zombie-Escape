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

    }

    private void SetVelocity()
    {
        
    }
}
