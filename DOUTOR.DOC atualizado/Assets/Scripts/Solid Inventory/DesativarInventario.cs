using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarInventario : MonoBehaviour
{
    public GameObject inventario;

    private void OnEnable()
    {
        inventario.SetActive(false);
    }
}
