using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascaraMala : MonoBehaviour
{
    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera, chaveCam, retratoCam, morcegoCam, mascaraCam, coroaCam;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        mascaraCam.SetActive(true);
        coroaCam.SetActive(false);
        chaveCam.SetActive(false);
        envelopeCamera.SetActive(false);
        hemagluCamera.SetActive(false);
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCcamera.SetActive(false);
        retratoCam.SetActive(false);
        morcegoCam.SetActive(false);

    }
}
