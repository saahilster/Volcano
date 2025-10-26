using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    private Vector3 offset = Vector3.zero;
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
