using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaSpikeColeta : MonoBehaviour
{
    public GameObject proteinaSpikeMala;
    public GameObject imagem;


    void OnMouseDown()
    {
        Destroy(gameObject);
        proteinaSpikeMala.SetActive(true);
        imagem.SetActive(true);
    }
}
