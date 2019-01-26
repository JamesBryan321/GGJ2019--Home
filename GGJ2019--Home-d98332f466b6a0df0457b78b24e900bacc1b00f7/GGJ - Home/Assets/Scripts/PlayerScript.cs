using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    AudioSource hurt;

    [SerializeField] Animator anim;
    
    // Start is called before the first frame update
    void Start()
         
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "small")
        {
            anim.SetBool("small" , true);
        }
    }

    //void Die()
}
