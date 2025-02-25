using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torqueAmount = 1;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 15f;
    private bool canMove = true;

    public void DisablePlayer(){
        canMove = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }

    }


    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            surfaceEffector2D.speed = boostSpeed;
        } else {
            surfaceEffector2D.speed = baseSpeed;
            
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
