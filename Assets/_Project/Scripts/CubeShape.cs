using UnityEngine;

// POLYMORPHISM
public class CubeShape : Shape
{
    private Vector3 targetPosition;
    private float moveSpeed = 5f;
    private float changeInterval = 1f;
    private float timer = 0f;

    private void Start()
    {
        ShapeName = "Cube";
        ShapeColor = Color.blue;
        ApplyColor();
        SetNewTargetPosition();
    }

    public override void DisplayText()
    {
        Debug.Log($"This is a {ShapeName}, You did great by clicking on the {ShapeName}!");
    }

    public override void Move()
    {
        timer += Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (timer >= changeInterval)
        {
            SetNewTargetPosition();
            timer = 0f;
        }
    }

    private void SetNewTargetPosition()
    {
        float randomX = Random.Range(-5f, 5f);
        float randomY = Random.Range(-5f, 5f);
        float randomZ = Random.Range(0f, 5f);
        targetPosition = new Vector3(randomX, randomY, randomZ);
    }

    protected override void AddScore()
    {
        GameManager.Instance.AddScore(15);
    }
}