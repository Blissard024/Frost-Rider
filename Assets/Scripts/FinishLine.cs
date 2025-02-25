using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") {

            Debug.Log("You finished!");
        }

        if(other.tag == "Player") {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
        }
    }


    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
  
}
