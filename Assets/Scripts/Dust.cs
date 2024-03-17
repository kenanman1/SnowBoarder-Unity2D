using UnityEngine;

public class Dust : MonoBehaviour
{
    [SerializeField]
    ParticleSystem dustParticle;

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Level Platform Sprite Shape")
            dustParticle.Stop();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Level Platform Sprite Shape")
            dustParticle.Play();
    }
}