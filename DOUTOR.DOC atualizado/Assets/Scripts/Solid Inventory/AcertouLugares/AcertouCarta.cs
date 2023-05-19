using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCarta : MonoBehaviour
{
    public GameObject cartaMala, cartaFinal, cartaCamera;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;
    [SerializeField] private Animator Colunas;

    private void OnMouseDown()
    {
        cartaFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {


            Destroy(gameObject);
            Destroy(cartaMala);
            cartaCamera.SetActive(false);

            Colunas.SetBool("Open", true); 
            
        }
        else
        {
            Destroy(gameObject);
            Destroy(cartaMala);
            cartaCamera.SetActive(false);
        }

    }
}
