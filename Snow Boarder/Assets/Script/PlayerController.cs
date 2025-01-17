using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 9f;
    Rigidbody2D rb;
    CircleCollider2D spriteHead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-torqueAmount);
        }
    }
}
