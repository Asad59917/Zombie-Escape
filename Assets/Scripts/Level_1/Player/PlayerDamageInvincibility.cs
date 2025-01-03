using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageInvincibility : MonoBehaviour
{
    [SerializeField]
    private float m_InvincibilityMultiplier;

    [SerializeField]
    private Color _flashColor;

    [SerializeField]
    private int _numberOfFlashes;

    private  InvincibilityController _invincibilitycontroller;

    private void Awake()
    {
        _invincibilitycontroller = GetComponent<InvincibilityController>();
    }
    public void StartInvincibilty()
    {
        _invincibilitycontroller.StartInvincibility(m_InvincibilityMultiplier, _flashColor, _numberOfFlashes);
    }
}
