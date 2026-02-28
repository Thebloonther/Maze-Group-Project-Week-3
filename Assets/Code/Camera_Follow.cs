using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    Vector3 offset;

    Vector3 newpos;

    public float rotatedSpeed = 100f;

    public GameObject player;
    void Start()
    {
        offset=player.transform.position-transform.position; 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.J))
        {
            offset = Quaternion.AngleAxis(-rotatedSpeed * Time.deltaTime, Vector3.up)* offset;
        }
        if (Input.GetKey(KeyCode.K))
        {
            offset = Quaternion.AngleAxis(rotatedSpeed * Time.deltaTime, Vector3.up)* offset;
        }

        transform.position = player.transform.position - offset;

        transform.LookAt(player.transform);

    }
}
