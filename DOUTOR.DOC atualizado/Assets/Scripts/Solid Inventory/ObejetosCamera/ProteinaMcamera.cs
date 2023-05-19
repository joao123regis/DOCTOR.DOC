using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinaMcamera : MonoBehaviour
{
    //Objetos que serao ativados na mala;

    public GameObject proteinaMmala;

    //Objeto de acesso que será ativado

    public GameObject acessoProteinaMFinal;

    private void OnEnable()
    {
        acessoProteinaMFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoProteinaMFinal.SetActive(false);
        proteinaMmala.SetActive(true);
    }
}
