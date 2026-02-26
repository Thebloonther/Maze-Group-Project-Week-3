using UnityEngine;

public class WinCond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public Transform goal;
    private float winDis = 3f;

    private bool won = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (won) return;

        float distance = Vector3.Distance(player.position, goal.position);
        
        if (distance <= winDis)
        {
            won = true;
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        Debug.Log("you win");
    }
}
