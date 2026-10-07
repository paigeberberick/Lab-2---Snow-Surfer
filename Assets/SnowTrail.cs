using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;

    int floorLayer;

    void Awake()
    {
        floorLayer = LayerMask.NameToLayer("Floor");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == floorLayer)
        {
            snowParticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == floorLayer)
        {
            snowParticles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}