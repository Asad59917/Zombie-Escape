using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy enemy when bullet collides with it
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        // Destroy wall tileset when bullet collides with it
        if (collision.CompareTag("Walls"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
