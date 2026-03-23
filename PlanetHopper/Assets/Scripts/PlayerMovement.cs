using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 12f;

    public Transform cameraTransform;

    Rigidbody rb;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 camForward = Vector3.ProjectOnPlane(cameraTransform.forward, transform.up);
        Vector3 camRight = Vector3.ProjectOnPlane(cameraTransform.right, transform.up);

        camForward.Normalize();
        camRight.Normalize();

        Vector3 move = camForward * v + camRight * h;

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);

        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move, transform.up);
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRotation,
                10f * Time.deltaTime
            );
        }
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (anim != null)
        {
            anim.SetFloat("MoveX", h);
            anim.SetFloat("MoveY", v);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float force = rb.mass * jumpForce; // F = ma
            rb.AddForce(transform.up * force, ForceMode.Impulse);
        }
    }
}