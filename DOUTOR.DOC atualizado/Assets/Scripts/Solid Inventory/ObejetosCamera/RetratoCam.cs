using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetratoCam : MonoBehaviour
{
    public GameObject retratoMala;

    //Objeto de acesso que será ativado

    public GameObject acessoRetratoFinal;

    private void OnEnable()
    {
        acessoRetratoFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoRetratoFinal.SetActive(false);
        retratoMala.SetActive(true);
    }
}
