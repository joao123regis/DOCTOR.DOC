using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouCoroa : MonoBehaviour
{
    public GameObject coroaMala, coroaFinal, coroaCamera;

    public Transform carta;
    public Transform morcego;
    public Transform mascara;
    public Transform coroa;
    [SerializeField] private Animator Colunas;

    private void OnMouseDown()
    {
        coroaFinal.SetActive(true);

        if ((carta.gameObject.activeSelf) && (morcego.gameObject.activeSelf) && (mascara.gameObject.activeSelf) && (coroa.gameObject.activeSelf))
        {
            


            Destroy(gameObject);
            Destroy(coroaMala);
            coroaCamera.SetActive(false);

            Colunas.SetBool("Open", true);


        }
        else
        {
            Destroy(gameObject);
            Destroy(coroaMala);
            coroaCamera.SetActive(false);
        }

    }
}
