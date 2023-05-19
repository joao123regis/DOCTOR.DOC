using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascaraCam : MonoBehaviour
{
    public GameObject mascaraMala;

    //Objeto de acesso que será ativado

    public GameObject acessoMascaraFinal;

    private void OnEnable()
    {
        acessoMascaraFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoMascaraFinal.SetActive(false);
        mascaraMala.SetActive(true);
    }
}
