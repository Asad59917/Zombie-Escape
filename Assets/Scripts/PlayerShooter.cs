using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;

    [SerializeField]
    private float BulletSpeed;

    [SerializeField]
    private Transform BulletPosition;

    [SerializeField]
    private float TimeBtwnShots;

    private bool FireContiniously;
    private float LastFireTime;


    // Update is called once per frame
    void Update()
    {
        if (FireContiniously)
        {
            float TimeScinceLastFire = Time.time - LastFireTime;

            if (TimeScinceLastFire >= TimeBtwnShots)
            {
                FireBullet();

                LastFireTime = Time.time;
            }
        }
    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(BulletPrefab, BulletPosition.position, BulletPosition.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = BulletSpeed * transform.up;
    }

    private void OnFire(InputValue inputValue) 
    {
        FireContiniously = inputValue.isPressed;
    }
}
