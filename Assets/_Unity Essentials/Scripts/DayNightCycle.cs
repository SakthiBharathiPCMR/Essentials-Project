using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Length of a full day in real-world seconds (editable in the Inspector)
    [Tooltip("The duration of a full day in seconds.")]
    public float dayDurationInSeconds = 120f; // Default 2 minutes

    // The rotation axis of the directional light (simulates sun's movement)
    private Vector3 rotationAxis = Vector3.right;

    // Total rotation for a complete day (360 degrees)
    private const float fullRotation = 360f;

    void Update()
    {
        // Calculate the rotation speed based on the full day duration
        float rotationSpeed = fullRotation / dayDurationInSeconds;

        // Rotate the light based on the calculated speed
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}