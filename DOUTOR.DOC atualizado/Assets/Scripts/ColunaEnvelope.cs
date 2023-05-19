using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColunaEnvelope : MonoBehaviour
{
    public GameObject envelope; 
    int controle; 

    private void OnMouseDown()
    {
        envelope.SetActive(true);
        controle = controle + 1; 

    }
}
