using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduzirFormula : MonoBehaviour
{
    public GameObject painelMicroscopio;
    public GameObject amostra;
    [Range(0.1f, 4.0f)] public float tempo = 1;

    public void Produzir()
    {
        StartCoroutine("ProducaoFarmaco");
    }

    IEnumerator ProducaoFarmaco()
    {
        if (amostra != null && painelMicroscopio != null)
        {
            painelMicroscopio.SetActive(false);
            yield return new WaitForSeconds(tempo);
            amostra.SetActive(true);
        }
    }
}
