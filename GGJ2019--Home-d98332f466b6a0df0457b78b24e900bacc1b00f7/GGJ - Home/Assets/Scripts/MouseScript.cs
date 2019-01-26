using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] AudioSource hurt;

    void Start()
    {
        GetComponent<Animator>();
        GetComponent<NavMeshAgent>();
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
        AudioSource.Play();
        //Player.Die.Death();
        //NavMeshAgent.SetDestination(Player.transform.position);
    }
}
