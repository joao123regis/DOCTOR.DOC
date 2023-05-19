using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCompleto : MonoBehaviour
{
    public GameObject envelopeCompletoMala;
    public GameObject imagem;

    void OnMouseDown()
    {
        Destroy(gameObject);
        envelopeCompletoMala.SetActive(true);
        imagem.SetActive(true);
    }
}
