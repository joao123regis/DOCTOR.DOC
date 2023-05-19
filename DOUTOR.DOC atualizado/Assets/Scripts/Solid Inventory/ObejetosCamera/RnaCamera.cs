using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RnaCamera : MonoBehaviour
{
    //Objetos que serao ativados na mala;

    public GameObject rnaMala;

    //Objeto de acesso que será ativado

    public GameObject acessoRnaFinal;

    private void OnEnable()
    {
        acessoRnaFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoRnaFinal.SetActive(false);
        rnaMala.SetActive(true);
    }
}
