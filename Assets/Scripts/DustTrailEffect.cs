using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrailEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticleEffect;
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Ground") {
            dustParticleEffect.Play();
        }
    }

        private void OnCollisionExit2D(Collision2D other) {
        
        if(other.gameObject.tag == "Ground") {
            dustParticleEffect.Stop();
        }
    }

}
