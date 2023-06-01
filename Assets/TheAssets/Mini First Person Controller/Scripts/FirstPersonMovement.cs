using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    Rigidbody rigidbody;
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        IsRunning = canRun && Input.GetKey(runningKey);

        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Erhalte die Blickrichtung des Spielers
        Vector3 forwardDirection = transform.forward;
        forwardDirection.y = 0; // Ignoriere die vertikale Komponente der Blickrichtung
        forwardDirection.Normalize(); // Normalisiere den Vektor, um die Geschwindigkeit beizubehalten

        Vector2 targetVelocity = new Vector2(forwardDirection.x * targetMovingSpeed, forwardDirection.z * targetMovingSpeed);

        rigidbody.velocity = new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }
}