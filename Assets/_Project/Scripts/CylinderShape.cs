using UnityEngine;

public class CylinderShape : Shape
{
    private void Start()
    {
        ShapeName = "Cylinder";
        ShapeColor = Color.green;
        ApplyColor();
    }

    public override void DisplayText()
    {
        Debug.Log($"Whoa! A {ShapeName} was clicked!");
    }
}

