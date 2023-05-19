using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChamarCenaPrincipal : MonoBehaviour
{
    public GameObject vencedor;

    public LevelLoader LevelLoader;



    public void CenaPrincipal()
    {
        Destroy(vencedor);
        Time.timeScale = 1;
        LevelLoader.Transition("SampleScene");
    }
}
