using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alavanc : MonoBehaviour
{
    bool virado = false; 
    public bool podeVirar = true; 

    public GameObject bola; 
    public Material bolaDesligado;
    public Material bolaLigado; 

    public GameObject controlador; 

    IEnumerator mudar()
    {
        yield return new WaitForSeconds(1f);
        podeVirar = true; 
        virado = !virado; 
        
        if (virado)
        {
            bola.GetComponent<Renderer>().material = bolaLigado; 
        }
        else
        {
            bola.GetComponent<Renderer>().material = bolaDesligado;

        }

        controlador.GetComponent<alavancaPuzzle>().receberSinal(gameObject, virado); 

    }
    void OnMouseDown(){
        if (podeVirar)
        {
            podeVirar = false; 
            if(!virado)
            { 
              GetComponent<Animation>().Play("Lever|LeverAction"); 
              StartCoroutine(mudar()); 


            }
            else
            {

              GetComponent<Animation>().Play("LeverDown");
              StartCoroutine(mudar()); 

            }

        }
      
    

    }
}