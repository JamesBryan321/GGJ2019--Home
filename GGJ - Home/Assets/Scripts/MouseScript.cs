using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseScript : MonoBehaviour
{
    [SerializeField] GameObject Player;

    void Start()
    {
        GetComponent<Animator>();
        GetComponent<NavMeshAgent>();
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
        //NavMeshAgent.SetDestination(Player.transform.position);
    }
}
