using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelMicroscopio : MonoBehaviour
{
    private RotacaoHorizontal rotacaoHorizontal;
    private RotacaVertical rotacaoVertical;
    private CameraZoom cameraZoom;
    public GameObject manual;
    public GameObject malaInventario;
    public GameObject esconderMala;


    private void OnEnable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: false);
        rotacaoVertical.CancelCameraVertical(value: false);
        cameraZoom.CancelZoom(value: false);

        manual.SetActive(false);
        malaInventario.SetActive(false);
    }

    private void OnDisable()
    {
        rotacaoHorizontal = FindObjectOfType<RotacaoHorizontal>();
        rotacaoVertical = FindObjectOfType<RotacaVertical>();
        cameraZoom = FindObjectOfType<CameraZoom>();

        rotacaoHorizontal.CancelCamera(value: true);
        rotacaoVertical.CancelCameraVertical(value: true);
        cameraZoom.CancelZoom(value: true);

        manual.SetActive(true);
        malaInventario.SetActive(true);
        esconderMala.SetActive(false);
    }
}