using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessoFliperama : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public string sceneName;

    public LevelLoader levelLoader;

    // Start is called before the first frame update
    void Start()
    {
        mouseDentroDoObjeto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                levelLoader.Transition(sceneName);
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
