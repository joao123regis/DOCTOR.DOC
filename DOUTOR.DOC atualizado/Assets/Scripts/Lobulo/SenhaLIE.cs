using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenhaLIE : MonoBehaviour
{
    public GameObject campodeSenha;

    // Start is called before the first frame update
    private void Start()
    {
        AcessoLIE.LobuloIE += aparecer;
    }

    public void aparecer()
    {
        if(Input.GetMouseButtonDown(0))
        {
            campodeSenha.SetActive(true);
        }
        
    }
}
