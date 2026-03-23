using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform player;

    public float height = 6f;  
    public float distance = 5f;   
    public float followSpeed = 5f;

    void LateUpdate()
    {
        Vector3 offset = (player.up * height) - (player.forward * distance);
        Vector3 targetPosition = player.position + offset;

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime
        );

        Quaternion targetRotation = Quaternion.LookRotation(
            player.position - transform.position,
            player.up
        );

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            followSpeed * Time.deltaTime
        );
    }
}