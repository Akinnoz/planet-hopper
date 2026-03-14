using UnityEngine;

public class GravityController : MonoBehaviour
{
    public Transform planet;
    public float gravityForce = 20f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direction = (planet.position - transform.position).normalized;

        rb.AddForce(direction * gravityForce);

        transform.up = -direction;
    }
}