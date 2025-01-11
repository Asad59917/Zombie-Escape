using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdiffuser2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet")){
            Destroy(other.gameObject);

        }
    }
}
