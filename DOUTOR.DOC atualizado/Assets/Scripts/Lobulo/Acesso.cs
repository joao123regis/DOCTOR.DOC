using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acesso : MonoBehaviour
{
    public GameObject imagem;
    [Range(0.1f, 4.0f)] public float tempoImagem = 1;
    bool mouseDentroDoObjeto;
    public delegate void AcessoLobulo();
    public static event AcessoLobulo OnEnemyDied;
    public Transform kaypadSE;
    public Transform kaypadID;
    public Transform kaypadIE;
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
            if (OnEnemyDied != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if ((kaypadSE.gameObject.activeSelf) || (kaypadID.gameObject.activeSelf) || (kaypadIE.gameObject.activeSelf) || (kaypadC.gameObject.activeSelf))
                    {
                        StartCoroutine("ImagemNaTela");
                    }
                    else
                    {
                        OnEnemyDied();
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
