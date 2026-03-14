using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed);
    }
}
