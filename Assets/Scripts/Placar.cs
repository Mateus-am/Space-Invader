using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour
{
    public static int pontos;
    public Text textopontos;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textopontos.text = pontos.ToString();
    }
}
