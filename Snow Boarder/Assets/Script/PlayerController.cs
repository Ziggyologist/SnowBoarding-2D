using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 9f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 18f;
    [SerializeField] float finishSpeed = 5f;



    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector;



    bool canMove = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            SpeedUpPlayer();
        }
    }
    public void SetFinishSpeed()
    {
        surfaceEffector.speed = finishSpeed;
    }

    public void DisableControls()
    {
        canMove = false;
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
