using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 0.5f;
    [SerializeField] ParticleSystem crashFX;
    [SerializeField] AudioClip crashSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            crashFX.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke(nameof(ReloadScene), reloadDelay);
        }
    }

    private void ReloadScene()
    {
        Debug.Log("Mutulici s-a lovit la cap.");
        SceneManager.LoadScene(0);
    }
}
