using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouMascara : MonoBehaviour
{
    public GameObject mascaraMala, mascaraFinal, mascaraCamera;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;
    [SerializeField] private Animator Colunas;

    private void OnMouseDown()
    {
        mascaraFinal.SetActive(true);


        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {


            Destroy(gameObject);
            Destroy(mascaraMala);
            mascaraCamera.SetActive(false);

            Colunas.SetBool("Open", true);


        }
        else
        {
            Destroy(gameObject);
            Destroy(mascaraMala);
            mascaraCamera.SetActive(false);
        }

    }
}
