using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AtivarObjetos : MonoBehaviour
{
    public GameObject ativado, formula;

    public Transform rna;
    public Transform hemaglu;
    public Transform proteinaSP;
    public Transform proteinaM;
    public Transform envelope;

    private void OnMouseDown(){

        ativado.SetActive(true);

        if ((rna.gameObject.activeSelf) && (hemaglu.gameObject.activeSelf) && (proteinaSP.gameObject.activeSelf) && (proteinaM.gameObject.activeSelf) && (envelope.gameObject.activeSelf))
        {
            formula.SetActive(true);
        }
    }
}
