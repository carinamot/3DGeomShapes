
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShapeSelection : MonoBehaviour
{
    private int selectedShapeIndex;
    private Color desiredColor; 

    [Header("List of shapes")]
    [SerializeField] private List<ShapeSelectionObject> shapeList = new List<ShapeSelectionObject>();

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI shapeName;
    [SerializeField] private Image shape;
    [SerializeField] private Image backgroundColor;

    private void Start()
    {
        UpdateShapeSelection();
    }
    public void LeftArrow()
    {
        selectedShapeIndex--;
        if (selectedShapeIndex < 0)
        { selectedShapeIndex = shapeList.Count - 1; }

        UpdateShapeSelection();
    }
    public void RightArrow()
    {
        selectedShapeIndex++;
        if (selectedShapeIndex == shapeList.Count)
        { selectedShapeIndex = 0; }

        UpdateShapeSelection();
    }
    private void UpdateShapeSelection()
    {
        shape.sprite=shapeList[selectedShapeIndex].mask;
        shapeName.text = shapeList[selectedShapeIndex].shapeName;
        desiredColor = shapeList[selectedShapeIndex].shapeColor;
    }

    [System.Serializable]
    public class ShapeSelectionObject
    {
        public Sprite mask;
        public string shapeName;
        public Color shapeColor; 
    }
}

