using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    public GameObject Movement;
    // Start is called before the first frame update
    void Start()
    {
        
       Instantiate(Movement, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Inimigo"))
        {
            
        }
        else
        {
            Instantiate(Movement, transform.position, Quaternion.identity);
        }
    }
}
