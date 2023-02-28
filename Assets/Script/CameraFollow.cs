using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)] public float smoothfactor;

    private void FixedUpdate()
    {
        transform.position= target.position+offset;
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,targetPosition,smoothfactor*Time.fixedDeltaTime);
        transform.position = targetPosition;

    }
}
