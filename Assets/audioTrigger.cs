using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    private bool hasPlayed = false;

    private void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true; // Ensures the sound only plays once
        }
    }
}

