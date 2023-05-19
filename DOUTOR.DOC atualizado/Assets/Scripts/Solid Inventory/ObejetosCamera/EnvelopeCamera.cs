using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvelopeCamera : MonoBehaviour
{

    //Objetos que serao ativados na mala;

    public GameObject envelopeCmala;

    //Objeto de acesso que será ativado

    public GameObject acessoEnvelopeCFinal;

    private void OnEnable()
    {
        acessoEnvelopeCFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoEnvelopeCFinal.SetActive(false);
        envelopeCmala.SetActive(true);
    }
}
