using UnityEngine;

public class GhostIncoming : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 1f;
    Vector3 PlayerLoc;
    Vector3 movement; 
    public Transform target;
    public GameObject player;

    void Start()
    {
        PlayerLoc = player.transform.position-transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //movement = new Vector3(x, 0f, z) * moveSpeed;
        //transform.Translate(movement * moveSpeed * Time.deltaTime, Space.self);
        if (target != null)
        {
            Vector3 playerLoc = target.position;
            Vector3 direction = playerLoc - transform.position;

            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
