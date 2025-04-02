using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    // Abstract method for polymorphism
    public abstract void DisplayText();

    // Common behavior for all shapes
    protected void OnMouseDown()
    {
        DisplayText();
    }

    // Method to set the color in the material
    protected void ApplyColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = ShapeColor;
        }
    }
}