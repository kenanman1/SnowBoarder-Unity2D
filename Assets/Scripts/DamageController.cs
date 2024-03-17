using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    [SerializeField]
    float reloadTime = 0.4f;
    [SerializeField]
    ParticleSystem damageEffect;
    bool isDead = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "StartLine" && !isDead)
        {
            DisableControl();
            GetComponent<AudioSource>().Play();
            damageEffect.Play();
            Invoke("Restart", reloadTime);
        }
    }

    public void DisableControl()
    {
        isDead = true;
        transform.GetComponent<PlayerController>().enabled = false;
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
