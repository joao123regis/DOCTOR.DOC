using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorcegoCam : MonoBehaviour
{
    public GameObject morcegoMala;

    //Objeto de acesso que será ativado

    public GameObject acessoMorcegoFinal;

    private void OnEnable()
    {
        acessoMorcegoFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoMorcegoFinal.SetActive(false);
        morcegoMala.SetActive(true);
    }
}
