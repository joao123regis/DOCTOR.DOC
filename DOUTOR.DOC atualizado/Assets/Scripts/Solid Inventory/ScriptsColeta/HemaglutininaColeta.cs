using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemaglutininaColeta : MonoBehaviour
{
    public GameObject hemaglutininaMala;
    public GameObject imagem;


    void OnMouseDown()
    {
        Destroy(gameObject);
        hemaglutininaMala.SetActive(true);
        imagem.SetActive(true);
    }
}
