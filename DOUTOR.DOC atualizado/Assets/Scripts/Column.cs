using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private bool objectPlaced = false; 


    public void ObjectPlaced(GameObject objectToActivate)
    {
        if(!objectPlaced)
        {
            objectToActivate.SetActive(true); 
            objectPlaced = true; 
            ColumnManager columnManeger = FindObjectOfType<ColumnManager>();
            columnManeger.ObjectPlaced(); 
        }
    }
}
