using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouRna : MonoBehaviour
{
    public GameObject rnaMala, rnaFinal, rnaCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(rnaMala);
        rnaCamera.SetActive(false);
        rnaFinal.SetActive(true);

    }
}
