using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouPM : MonoBehaviour
{
    public GameObject pmMala, pmFinal, pmCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(pmMala);
        pmCamera.SetActive(false);
        pmFinal.SetActive(true);

    }
}
