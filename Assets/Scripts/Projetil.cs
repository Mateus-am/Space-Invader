using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade;
    public float tempoDeVida;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, tempoDeVida);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
        }
        if (c.gameObject.tag == "Escudo")
        {
            Destroy(gameObject);
        }
    }
    

}
