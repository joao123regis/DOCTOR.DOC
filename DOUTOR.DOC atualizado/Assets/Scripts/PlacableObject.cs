using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacableObject : MonoBehaviour
{
    public GameObject column;
    public GameObject objectToActivate;

    private bool isPlaced = false; 

    private void OnMouseDown()
    {
        if (!isPlaced)
        {
            column.GetComponent<Column>().ObjectPlaced(objectToActivate);
            isPlaced = true; 
        }
    } 
}
