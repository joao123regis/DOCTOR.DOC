using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoMap : MonoBehaviour
{
    bool mouseDentroDoObjeto; 
    public GameObject Map; 

    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Map.SetActive(true); 
  
            }

        }
    }


    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }
    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
