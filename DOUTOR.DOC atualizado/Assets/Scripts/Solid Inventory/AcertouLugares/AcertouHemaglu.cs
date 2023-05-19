using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouHemaglu : MonoBehaviour
{
    public GameObject hemagluMala, hemagluFinal, hemagluCamera;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(hemagluMala);
        hemagluCamera.SetActive(false);
        hemagluFinal.SetActive(true);

    }
}
