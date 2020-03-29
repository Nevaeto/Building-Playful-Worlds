using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    public Transform Sparkles;


     void Start()
    {
        Sparkles.GetComponent<ParticleSystem>().Stop();

    }
    void OnTriggerEnter ()
    {
        Debug.Log ("Start Particles");
        Sparkles.GetComponent<ParticleSystem>().Play();
    }

}
