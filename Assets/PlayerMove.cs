using UnityEngine;

public class PlayerMove_Velocity : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody rb;

    void Awake() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Vector3 v = new Vector3(input.x, 0f, input.y) * speed;

        // Unity 6+ uses linearVelocity; older Unity uses velocity
        rb.linearVelocity = new Vector3(v.x, rb.linearVelocity.y, v.z);
        // rb.velocity = new Vector3(v.x, rb.velocity.y, v.z);
    }
}