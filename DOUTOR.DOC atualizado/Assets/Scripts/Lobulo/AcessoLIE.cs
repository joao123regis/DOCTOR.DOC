using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoLIE : MonoBehaviour
{
    public GameObject imagem;
    [Range(0.1f, 4.0f)] public float tempoImagem = 1;
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo LobuloIE;
    public Transform kaypadSD;
    public Transform kaypadID;
    public Transform kaypadSE;
    public Transform kaypadC;

    // Update is called once per frame

    void Start()
    {
        mouseDentroDoObjeto = false;

        if (imagem != null)
        {
            imagem.SetActive(false);
        }
    }
    
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if(LobuloIE != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if ((kaypadSD.gameObject.activeSelf) || (kaypadID.gameObject.activeSelf) || (kaypadSE.gameObject.activeSelf) || (kaypadC.gameObject.activeSelf))
                    {
                        StartCoroutine("ImagemNaTela");
                    }
                    else
                    {
                        LobuloIE();
                    }


                }

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

    IEnumerator ImagemNaTela()
    {
        if (imagem != null)
        {
            imagem.SetActive(true);
            yield return new WaitForSeconds(tempoImagem);
            imagem.SetActive(false);
        }
    }
}
