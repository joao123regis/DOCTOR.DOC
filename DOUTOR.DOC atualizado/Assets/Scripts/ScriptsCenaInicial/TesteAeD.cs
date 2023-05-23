using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteAeD : MonoBehaviour
{
    void Update()
    {
       if((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D)))
        {
            Destroy(gameObject);
        } 
    }
}
