using UnityEngine;
public class StateMove1 : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    public float winDistance = 1.5f;
    private bool hasWon = false;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (hasWon) return;
        float distance = Vector3.Distance(player.position, goal.position);
        //Debug.Log(distance);
        if (distance <= winDistance) 
        {
            hasWon = true;
            WinGame();
        }
    }
    void WinGame()
    {
        animator.SetTrigger("SrateTurn1");
    }
}