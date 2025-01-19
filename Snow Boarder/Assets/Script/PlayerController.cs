using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 9f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 18f;

    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        SpeedUpPlayer();
    }

    private void SpeedUpPlayer()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
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
