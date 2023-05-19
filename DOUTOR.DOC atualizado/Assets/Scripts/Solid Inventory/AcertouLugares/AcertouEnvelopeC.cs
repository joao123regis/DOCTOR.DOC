using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouEnvelopeC : MonoBehaviour
{
    public GameObject envelopeCMala, envelopeCFinal, envelopeCCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(envelopeCMala);
        envelopeCCamera.SetActive(false);
        envelopeCFinal.SetActive(true);

    }
}
