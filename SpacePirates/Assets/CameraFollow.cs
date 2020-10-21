using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //target and Vector3 offset are determined in unity editor
    public Transform target;

    //higher value makes camera lock onto target faster.  between 0 and 1
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;

        //lerp means linear interpolation. smoothly moves from first parameter to second and takes in float
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        //transform.position gives camera's position
        transform.position = smoothedPosition;
    }
}
