using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroaCam : MonoBehaviour
{
    public GameObject coroaMala;

    //Objeto de acesso que será ativado

    public GameObject acessoCoroaFinal;

    private void OnEnable()
    {
        acessoCoroaFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoCoroaFinal.SetActive(false);
        coroaMala.SetActive(true);
    }
}
