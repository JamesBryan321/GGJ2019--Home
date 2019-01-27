using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseScript : MonoBehaviour
{
    public Transform Player;
    public Transform Trap;
    public AudioClip hurt;
    public float lookRadius = 2f;

    public NavMeshAgent agent;

    void Start()
    {
        GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //Player.GetComponent<Die>().Death();

    }

    void Update() 
    {
        float distance = Vector3.Distance(Player.position, transform.position);
        float distance1 = Vector3.Distance(Trap.position, transform.position);

        if (distance <= lookRadius)
        {

            agent.SetDestination(Player.transform.position);

            if (distance <= agent.stoppingDistance)
            {
                //Attack the target
                FaceTarget();
            }
        }
        else if (distance1 <= lookRadius)
        {
            agent.SetDestination(Trap.transform.position);

            if (distance <= agent.stoppingDistance)
            {
                //Attack the target
                FaceTarget();
            }
        }
    
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Trap")
        //{
            Destroy(this.gameObject);
        //}
        
    }


    /*public void Attack()
    {
        Debug.Log("Attack");
        
        //Player.Die.Death();
        agent.SetDestination(Player.transform.position);
    }*/
    void FaceTarget()
    {
        Vector3 direction = (Player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
