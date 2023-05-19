using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveCam : MonoBehaviour
{
    public GameObject chaveMala;

    //Objeto de acesso que será ativado

    public GameObject acessoChaveFinal;

    private void OnEnable()
    {
        acessoChaveFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoChaveFinal.SetActive(false);
        chaveMala.SetActive(true);
    }
}
