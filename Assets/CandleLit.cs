using UnityEngine;

public class Candle : MonoBehaviour
{
    public ParticleSystem candleFlame; // Assign in the Inspector
    public Light pointLight; // Assign in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        Lighter lighter = other.GetComponent<Lighter>();
        if (lighter != null && lighter.isLit)
        {
            if (!candleFlame.isPlaying)
            {
                candleFlame.Play();
                pointLight.enabled = true; // Turn on the light when the candle is lit
                Debug.Log("Candle flame played. Light enabled.");
            }
        }
    }

    
    }

