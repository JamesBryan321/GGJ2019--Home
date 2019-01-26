using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Fall");
        }
        else if (other.tag == "Mouse")
        {
            anim.SetTrigger("Snap");
            Destroy(gameObject);
        }
    }
}
