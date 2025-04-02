using UnityEngine;

public class CubeShape : Shape
{
    private void Start()
    {
        ShapeName = "Cube";
        ShapeColor = Color.blue;
        ApplyColor();
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a {ShapeName}, nice choice!");
    }
}