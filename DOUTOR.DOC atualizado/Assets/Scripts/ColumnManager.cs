using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnManager : MonoBehaviour
{
    public GameObject[] columns;
    private int numObjectsPlaced = 0; 

    public void ObjectPlaced()
    {
        numObjectsPlaced++; 
        CheckCompletion(); 
    }

    private void CheckCompletion()
    {
        if (numObjectsPlaced == columns.Length)
        {
            Debug.Log("Todos os objetos foram posicionados corretamente!");

        }
    }
}
