using UnityEngine;

public class MoveIt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    public float jump = 7f;
    Vector3 movement; 
    Rigidbody rb;

    public Vector3 MoveVec { get; private set;}

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, 0f, z) * moveSpeed;

        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

        if (Input.GetKey(KeyCode.Space)){

            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jump, rb.linearVelocity.z);

        }
    }
}
