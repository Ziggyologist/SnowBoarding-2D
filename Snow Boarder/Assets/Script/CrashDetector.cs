using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Mutulici s-a lovit la cap.");
        }
    }
}
