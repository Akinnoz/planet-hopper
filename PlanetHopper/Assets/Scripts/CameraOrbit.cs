using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0, 1, -8);
    public float followSpeed = 5f;

    void LateUpdate()
    {
        Vector3 targetPosition = player.position + player.rotation * offset;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            player.rotation,
            followSpeed * Time.deltaTime
        );
    }
}