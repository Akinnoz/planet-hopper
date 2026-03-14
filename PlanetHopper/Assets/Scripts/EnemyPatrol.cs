using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform planet;
    public float moveSpeed = 5f;
    public float gravityForce = 25f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.WakeUp();
    }

    void FixedUpdate()
    {
        Vector3 gravityDir = (planet.position - transform.position).normalized;

        rb.AddForce(gravityDir * gravityForce, ForceMode.Acceleration);

        transform.up = -gravityDir;

        transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}