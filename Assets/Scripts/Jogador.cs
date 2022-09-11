using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidade = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float px = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(px, 0.0f, 0.0f);
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Projetil2")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Jogo");
        }
        if (c.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Jogo");
        }
    }
}
