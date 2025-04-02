using UnityEngine;

public class CapsuleShape : Shape
{
    private void Start()
    {
        ShapeName = "Capsule";
        ShapeColor = Color.red;
        ApplyColor();
    }

    public override void DisplayText()
    {
        Debug.Log($"You clicked a {ShapeName}!");
    }
}