using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSFX;
    private bool crashed;

    private void OnTriggerEnter2D(Collider2D other) {

       if(other.tag == "Ground"){
        Debug.Log("You hit the ground!");
       } 

        
        if(other.tag == "Ground") {

            if(crashed == false) {
                FindObjectOfType<PlayerController>().DisablePlayer();
                finishEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                Invoke("ReloadScene", loadDelay);
                crashed = true;
            }
  
        }

    }

        void ReloadScene() {
            SceneManager.LoadScene(0);
        }
  
}
