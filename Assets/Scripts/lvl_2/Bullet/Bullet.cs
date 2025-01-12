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
            GameObject enemyExlpotion = Instantiate(WallsDestroyParticle, transform.position, transform.rotation);
            Destroy(enemyExlpotion, 0.75f);


            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }

    public GameObject WallsDestroyParticle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
