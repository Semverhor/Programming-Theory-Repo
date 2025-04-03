using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10000f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}