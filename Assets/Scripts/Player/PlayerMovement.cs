using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    [SerializeField]
    private float RotationSpeed;

    private Rigidbody2D RigiBody2d;
    private Vector2 MovementInput;
    private Vector2 SmoothMovementIutput;
    private Vector2 MovementIutputSmoothVelocity;
    private Animator animator;

    private void Awake()
    {
       RigiBody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateDirectionInput();
        setAnimation();
    }

    private void setAnimation()
    {
        bool ismoving = MovementInput != Vector2.zero;

        animator.SetBool("IsMoving", ismoving);
    }
    private void SetPlayerVelocity()
    {
        SmoothMovementIutput = Vector2.SmoothDamp(
            MovementInput,
            SmoothMovementIutput,
            ref MovementIutputSmoothVelocity,
            0.1f);
        RigiBody2d.velocity = SmoothMovementIutput * Speed;
    }

    private void RotateDirectionInput()
    {
        if (MovementInput != Vector2.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, SmoothMovementIutput);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);

            RigiBody2d.MoveRotation(rotation);
        }
    }

    private void OnMove(InputValue inputValue)
    {
        MovementInput = inputValue.Get<Vector2>();
    }
}
