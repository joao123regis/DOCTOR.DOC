using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteWeS : MonoBehaviour
{
    public GameObject testeWeS, testeAeD;
    [Range(0.1f, 4.0f)] public float tempo = 1;

    public void ChamaTutorialAeD()
    {
        StartCoroutine("ChamaTesteAeD");
    }

    IEnumerator ChamaTesteAeD()
    {
        if (testeWeS != null && testeAeD != null)
        {
            testeWeS.SetActive(false);
            yield return new WaitForSeconds(tempo);
            testeAeD.SetActive(true);
        }
    }
}
