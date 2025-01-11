using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack2 : MonoBehaviour
{
    [SerializeField]
    private float AmountDamaged;

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            var healthController = collision.gameObject.GetComponent<HealthController>();
            healthController.TakeDamage(AmountDamaged);
        }

        // Check if the collided object is an NPC
        if (collision.gameObject.CompareTag("NPC"))
        {
            var healthController = collision.gameObject.GetComponent<HealthController>();
            healthController.TakeDamage(AmountDamaged);
        }
    }
}
