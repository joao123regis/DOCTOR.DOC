using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMcoleta : MonoBehaviour
{
    public GameObject proteinaMmala;
    public GameObject imagem;

    void OnMouseDown()
    {
        Destroy(gameObject);
        proteinaMmala.SetActive(true);
        imagem.SetActive(true);
    }
}
