using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{
    private NavMeshAgent agent;

    private Animator ani;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        move();
    }

  
    private void move() 
     {
        if (Input.GetKeyDown("space"))
        {
            Vector3 target = new Vector3(Random.Range(4.1f, -14.7f), 0, Random.Range(4.1f, -14.7f));
            agent.SetDestination(target);
            ani.SetBool("跑步開關", true);
        }
        
       if(agent.remainingDistance <= 0)
        {
            ani.SetBool("跑步開關", false);
        }
     } 
}
