using UnityEngine;

public class GhostIncoming : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 1f;
    Vector3 PlayerLoc;
    Vector3 movement; 

    void Start()
    {
        PlayerLoc = player.transform.position-transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(x, 0f, z) * moveSpeed;
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.self);
    }
}
