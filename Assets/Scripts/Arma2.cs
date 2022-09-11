using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma2 : MonoBehaviour
{
    public GameObject ProjetilPrefab2;
    float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Tiro ());
    }

    // Update is called once per frame
    void Update()
    {
        intervalo = Random.Range(1.0f, 6.0f);
    }
    IEnumerator Tiro()
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(ProjetilPrefab2, transform.position, Quaternion.identity);
        StartCoroutine(Tiro ());
    }
}
