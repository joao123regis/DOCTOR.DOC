using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoCerto : MonoBehaviour
{
    [SerializeField] private Animator Mesa; 
    void girarMesa()
    {
        Mesa.SetBool("Open", true);
        StartCoroutine("StopMesa");
    }

    IEnumerator StopMesa()
    {
        yield return new WaitForSeconds(2f); 
        Mesa.SetBool("Open", false);
        Mesa.enabled = false; 
    }

    
}
