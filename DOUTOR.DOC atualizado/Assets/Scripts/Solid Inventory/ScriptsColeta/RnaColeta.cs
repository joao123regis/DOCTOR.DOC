using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RnaColeta : MonoBehaviour
{
    public GameObject rnaMala;
    public GameObject imagem;

    void OnMouseDown()
    {
        Destroy(gameObject);
        rnaMala.SetActive(true);
        imagem.SetActive(true);
    }
}
