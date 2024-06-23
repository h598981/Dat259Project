using UnityEngine;

public class BridgeCreakTrigger : MonoBehaviour
{
    private AudioSource creakingSound;

    private void Start()
    {
        creakingSound = GetComponent<AudioSource>();
        if (creakingSound == null)
        {
            Debug.LogError("AudioSource component missing from this GameObject");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && creakingSound != null)
        {
            creakingSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && creakingSound != null)
        {
            creakingSound.Stop();
        }
    }
}
