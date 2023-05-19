using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMorcego : MonoBehaviour
{
    public GameObject morcegoMala, morcegoFinal, morcegoCamera;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;
    [SerializeField] private Animator Colunas;

    private void OnMouseDown()
    {

        morcegoFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {


            Destroy(gameObject);
            Destroy(morcegoMala);
            morcegoCamera.SetActive(false);

            Colunas.SetBool("Open", true);

        }
        else
        {
            Destroy(gameObject);
            Destroy(morcegoMala);
            morcegoCamera.SetActive(false);
        }

    }
}
