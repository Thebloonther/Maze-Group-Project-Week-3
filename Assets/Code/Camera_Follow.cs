using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    Vector3 offset;

    Vector3 newpos;

    public GameObject player;
    void Start()
    {
        offset=player.transform.position-transform.position; 


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}
