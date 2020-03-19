using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    public Transform Sparkles;
    public AudioClip TriggerSound;
    AudioSource audioSource;

     void Start()
    {
        Sparkles.GetComponent<ParticleSystem>().Stop();
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter ()
    {
        Debug.Log ("Start Particles");
        Sparkles.GetComponent<ParticleSystem>().Play();

        if (TriggerSound != null)
        {
            audioSource.PlayOneShot(TriggerSound);
        }
    }

}
