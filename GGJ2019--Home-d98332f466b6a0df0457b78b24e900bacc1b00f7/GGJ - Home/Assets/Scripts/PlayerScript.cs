using System.Collections;
using System.Collections.Generic;
using Ladder.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerScript : MonoBehaviour
{
    AudioSource hurt;

    public Text start;


    [SerializeField] Animator anim;
    
    // Start is called before the first frame update
    void Start()
         
    {
        anim = GetComponent<Animator>();
        start.enabled = false;
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
            FirstPersonController.m_WalkSpeed = 1;
            FirstPersonController.m_RunSpeed = 2;
        }
        if(other.gameObject.tag == "death")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (other.gameObject.tag == "win")
        {
            SceneManager.LoadScene("Credits");
        }
        if(other.gameObject.tag == "start")
        {
            start.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "start")
        {
            start.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    //void Die()
}
