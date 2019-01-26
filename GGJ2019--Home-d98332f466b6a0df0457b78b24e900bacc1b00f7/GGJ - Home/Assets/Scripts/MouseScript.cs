using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseScript : MonoBehaviour
{
    public GameObject Player;
    public AudioClip hurt;

    private NavMeshAgent agent;

    void Start()
    {
        GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //Player.GetComponent<Die>().Death();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Attack();
        }
    }


    public void Attack()
    {
        Debug.Log("Attack");
        
        //Player.Die.Death();
        agent.SetDestination(Player.transform.position);
    }
}
