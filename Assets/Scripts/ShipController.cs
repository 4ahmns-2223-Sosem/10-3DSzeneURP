using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 10.0f;
    public float sensitivity = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        rotationX += Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;

        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.rotation = Quaternion.Euler(-rotationY, rotationX, 0);
    }
}