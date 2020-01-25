using UnityEngine;
using UnityEngine.AI;

public class Dog : MonoBehaviour
{
    private NavMeshAgent nav;
    private GameObject[] points;
    private Transform target;
    private Animator ani;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
        points = GameObject.FindGameObjectsWithTag("位置");
    }

    private void Update()
    {
        print(nav.velocity);

        MoveTo();
    }

    private void MoveTo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            target = points[Random.Range(0, points.Length)].transform;
        }

        if (target != null)
        {
            nav.SetDestination(target.position);

            if (nav.remainingDistance <= 0.1f)
            {
                ani.SetBool("跑步開關", !(nav.isStopped = true));
            }
            else
            {
                ani.SetBool("跑步開關", !(nav.isStopped = false));
            }
        }
    }
}
