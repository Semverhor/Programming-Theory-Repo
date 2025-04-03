using UnityEngine;


//INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    // ABSTRACTION
    public abstract void DisplayText();
    public abstract void Move();
    protected abstract void AddScore();

    protected void OnMouseDown()
    {
        DisplayText();
        AddScore();
    }

    protected void ApplyColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = ShapeColor;
        }
    }

    private void Update()
    {
        Move();
    }
}