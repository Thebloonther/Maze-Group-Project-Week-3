using UnityEngine;
using UnityEngine.SceneManagement;

public class CathbyG : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public Transform goal;
    private float teleDis = 1f;
    private bool won = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (won) return;

        float distance = Vector3.Distance(player.position, goal.position);

        if (distance <= teleDis)
        {
            won = true;
            Tele4();
        }
    }
    private void Tele4()
    {
        SceneManager.LoadScene("EndScene");
    }
}
