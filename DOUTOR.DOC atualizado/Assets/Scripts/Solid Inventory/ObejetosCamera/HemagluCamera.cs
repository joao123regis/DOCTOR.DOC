using UnityEngine;

public class HemagluCamera : MonoBehaviour
{
    //Objetos que serao ativados na mala;

    public GameObject hemagluMala;

    //Objeto de acesso que será ativado

    public GameObject acessoHemagluFinal;

    private void OnEnable()
    {
        acessoHemagluFinal.SetActive(true);
    }

    private void OnDisable()
    {
        acessoHemagluFinal.SetActive(false);
        hemagluMala.SetActive(true);
    }
}
