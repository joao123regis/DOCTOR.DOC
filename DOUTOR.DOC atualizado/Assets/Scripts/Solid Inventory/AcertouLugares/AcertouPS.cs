using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouPS : MonoBehaviour
{
    public GameObject psMala, psFinal, psCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(psMala);
        psCamera.SetActive(false);
        psFinal.SetActive(true);

    }
}
