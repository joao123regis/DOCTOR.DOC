using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaSPcamera : MonoBehaviour
{
    //Objetos que serao ativados na mala;

    public GameObject proteinaSPmala;

    //Objeto de acesso que será ativado

    public GameObject acessoProteinaSPFinal;

    private void OnEnable()
    {
        acessoProteinaSPFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoProteinaSPFinal.SetActive(false);
        proteinaSPmala.SetActive(true);
    }
}
