using UnityEngine;

// POLYMORPHISM
public class CylinderShape : Shape
{
    private Vector3 startPos;
    private float moveRange = 2f;

    private void Start()
    {
        ShapeName = "Cylinder";
        ShapeColor = Color.green;
        ApplyColor();
        startPos = transform.position;
    }

    public override void DisplayText()
    {
        Debug.Log($"Whoa, you managed to click on a {ShapeName}!");
    }

    public override void Move()
    {
        transform.position = startPos + Vector3.right * Mathf.PingPong(Time.time * 2, moveRange)
            - Vector3.right * (moveRange / 2);
    }
}

