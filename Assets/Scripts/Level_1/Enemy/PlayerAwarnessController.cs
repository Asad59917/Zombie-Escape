using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarnessController : MonoBehaviour
{
    public bool AwarnessOfPlayer {  get; private set; }

    public Vector2 DirectionOfPlayer { get; private set; }

    [SerializeField]
    public float PlayerAwarnessDistance;

    private Transform player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = player.position - transform.position;
        DirectionOfPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= PlayerAwarnessDistance)
        {
            AwarnessOfPlayer = true;
        }
        else 
        { 
            AwarnessOfPlayer = false;
        }
    }
}
