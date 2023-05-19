using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarObjetosCam : MonoBehaviour
{

    public GameObject envelopeCcamera, envelopeCamera, hemagluCamera, proteinaMcamera, proteinaSPcamera, rnaCamera, chaveCam, retratoCam, morcegoCam, mascaraCam, coroaCam;
    private CameraZoom cameraZoom;


    private void OnEnable()
    {
        cameraZoom = FindObjectOfType<CameraZoom>();
        cameraZoom.CancelZoom(value: false);
    }

    private void OnDisable()
    {
        chaveCam.SetActive(false);
        envelopeCamera.SetActive(false);
        hemagluCamera.SetActive(false);
        proteinaMcamera.SetActive(false);
        proteinaSPcamera.SetActive(false);
        rnaCamera.SetActive(false);
        envelopeCcamera.SetActive(false);
        retratoCam.SetActive(false);
        morcegoCam.SetActive(false);
        mascaraCam.SetActive(false);
        coroaCam.SetActive(false);

        cameraZoom = FindObjectOfType<CameraZoom>();
        cameraZoom.CancelZoom(value: true);
    }
}
