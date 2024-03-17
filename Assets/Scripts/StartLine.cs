using UnityEngine;

public class StartLine : MonoBehaviour
{
    [SerializeField]
    ParticleSystem startEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            startEffect.Play();
            print("Player has crossed the start line");
        }
    }
}
