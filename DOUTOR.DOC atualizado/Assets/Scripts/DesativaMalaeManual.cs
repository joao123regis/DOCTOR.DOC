using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativaMalaeManual : MonoBehaviour
{
    public GameObject manual, mala;

    private void OnEnable()
    {
        manual.SetActive(false);
        mala.SetActive(false);
    }

    private void OnDisable()
    {
        manual.SetActive(true);
        mala.SetActive(true);
    }
}
