using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20;

    private int playerVelocity;

    private float turnSpeed = 35;

    private float horizontalInput;

    private float forwardInput;

    private Rigidbody playerRb;

    [SerializeField] GameObject centerMass;

    [SerializeField] TextMeshProUGUI speedometerText;

    [SerializeField] List<WheelCollider> allWheels;

    private int wheelsOnGround;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();


        playerRb.centerOfMass = centerMass.transform.position;
    }


    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if(IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * speed);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

            playerVelocity = Mathf.RoundToInt(playerRb.velocity.magnitude);
            speedometerText.text = "Speed: " + playerVelocity + " KMH";
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach(WheelCollider wheel in allWheels)
        {
            if(wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if(wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }   
}
