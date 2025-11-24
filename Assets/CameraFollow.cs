using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // Objeto a seguir
    public Vector3 offset;     // Distancia entre cámara y objetivo
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

       transform.position = desiredPosition;
        transform.LookAt(target);
    }
}
