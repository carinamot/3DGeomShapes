using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlights : MonoBehaviour
{
    [SerializeField] private string obiectulSelectat = "Selectable";
    [SerializeField] private Material highlightedColor;
    [SerializeField] private Material normalColor;

    private Transform deselectare;

    void Update()
    {

        if(deselectare != null)
        {
            var selectionRenderer = deselectare.GetComponent<Renderer>();
            selectionRenderer.material = normalColor;
            deselectare = null;
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            var selectare = hit.transform;
            if (selectare.CompareTag(obiectulSelectat))
            {
                var selectionRenderer = selectare.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightedColor;
                   
                }

                deselectare = selectare;
            }
                
               
            
           
        }
    }
}
