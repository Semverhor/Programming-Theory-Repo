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
        transform.Translate(Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * 3f);
    }

    protected override void AddScore()
    {
        GameManager.Instance.AddScore(10);
    }
}