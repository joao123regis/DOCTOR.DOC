using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Transform pauseMenu;
    public GameObject caixa;
    public GameObject esfera;
    [SerializeField()] Vector3 rotacaoCaixa = new Vector3(0, 0, 0);
    Vector3 posicaoEsfera = new Vector3(0, 3, 5.5f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void ReiniciarGame()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
        caixa.transform.rotation = Quaternion.Euler(rotacaoCaixa);
        esfera.transform.position = posicaoEsfera; 
    }
}
