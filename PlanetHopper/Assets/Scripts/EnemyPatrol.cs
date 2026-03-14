using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform planet;
    public float moveSpeed = 2f;
    public float gravityForce = 25f;
    public float rotateSpeed = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 gravityDir = (planet.position - transform.position).normalized;

        rb.AddForce(gravityDir * gravityForce, ForceMode.Acceleration);

        Quaternion targetRotation =
            Quaternion.FromToRotation(transform.up, -gravityDir) * transform.rotation;

        transform.rotation =
            Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

        Vector3 moveDir = transform.right;

        rb.MovePosition(rb.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }
}