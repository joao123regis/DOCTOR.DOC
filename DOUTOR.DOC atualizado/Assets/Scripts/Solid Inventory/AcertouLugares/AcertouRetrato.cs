using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouRetrato : MonoBehaviour
{
    public GameObject retratoMala, retratoFinal, rretratoCamera;
    [SerializeField] private Animator PortaArmario; 

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(retratoMala);
        rretratoCamera.SetActive(false);
        retratoFinal.SetActive(true);
        PortaArmario.SetBool("Open", true); 

    }
}
