using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HemagluMala : MonoBehaviour
{
    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera, chaveCam, retratoCam, morcegoCam, mascaraCam, coroaCam;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        hemagluCamera.SetActive(true);
        envelopeCcamera.SetActive(false);  
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCamera.SetActive(false);
        chaveCam.SetActive(false);
        retratoCam.SetActive(false);
        morcegoCam.SetActive(false);
        mascaraCam.SetActive(false);
        coroaCam.SetActive(false);
    }
}
