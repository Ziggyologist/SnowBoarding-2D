using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    SceneManager SceneManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Mutulici a terminat");
            SceneManager.LoadScene(0);
        }
    }
}
