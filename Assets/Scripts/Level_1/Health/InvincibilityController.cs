using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    private HealthController healthController;
    private SpriteFlash _spriteFlash;

    private void Awake()
    {
        healthController = GetComponent<HealthController>();
        _spriteFlash = GetComponent<SpriteFlash>();
    }

    public void StartInvincibility (float invincibilityDuration, Color flashColor, int numberOfFlashes)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityDuration, flashColor, numberOfFlashes));
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityDuration, Color flashColor, int numberOfFlashes)
    {
        healthController.IsInvincible = true;
        yield return _spriteFlash.FlashCoroutine(invincibilityDuration, flashColor, numberOfFlashes);
        healthController.IsInvincible = false;
    }
}
