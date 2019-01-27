using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{



   public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "death")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
