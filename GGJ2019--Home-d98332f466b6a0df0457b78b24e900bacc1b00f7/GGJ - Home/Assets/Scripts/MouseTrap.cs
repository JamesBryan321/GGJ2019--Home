using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    public Animator anim;


    public GameObject mouse;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Fall");
            StartCoroutine("MyMethod");
            Destroy(mouse);
        }
        
        
    }

    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(4f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mouse")
        {
            Destroy(gameObject);
            Debug.Log("Snap!");
            anim.SetTrigger("Snap");
            
        }
    }
}
