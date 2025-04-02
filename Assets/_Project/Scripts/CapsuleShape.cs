using UnityEngine;

// POLYMORPHISM
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
        Debug.Log($"You clicked on a {ShapeName}!");
    }

    public override void Move()
    {
        transform.Translate(Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime);
    }
}