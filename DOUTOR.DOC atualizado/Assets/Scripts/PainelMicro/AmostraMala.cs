using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmostraMala : MonoBehaviour
{
    public GameObject amostraCamera, inventario, ativaInventario;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        amostraCamera.SetActive(true);
        ativaInventario.SetActive(false);
        inventario.SetActive(false);
    }
}
