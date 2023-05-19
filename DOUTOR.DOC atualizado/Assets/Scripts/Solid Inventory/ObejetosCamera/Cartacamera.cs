using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartacamera : MonoBehaviour
{
    //Objetos que serao ativados na mala;

    public GameObject cartaMala;

    //Objeto de acesso que será ativado

    public GameObject acessoCartaFinal;

    private void OnEnable()
    {
        acessoCartaFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoCartaFinal.SetActive(false);
        cartaMala.SetActive(true);
    }
}
