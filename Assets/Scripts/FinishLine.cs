using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    AudioSource audioSource;

    // Start is called before the first frame update
    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player")
        {
            finishEffect.Play();
            audioSource.Play();
            Invoke("ReloadScene", loadDelay);
        }

    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    } 
}
