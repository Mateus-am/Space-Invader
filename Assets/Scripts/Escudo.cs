using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Projetil")
        {
            Destroy(gameObject);
        }
        if (c.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
        }

    }
}
