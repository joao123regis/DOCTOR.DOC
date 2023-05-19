using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coluna2 : MonoBehaviour
{
    public GameObject ativado;  

    private void OnMouseDown(){
        ativado.SetActive(true);   
    }
}
