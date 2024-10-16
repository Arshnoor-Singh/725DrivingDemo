using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleController : MonoBehaviour
{
    private float accelerationInput;
    private float currentTurnInput;
    private float targetTurnInput;
    private Vector3 currentVelocity;

    public Rigidbody carBody;
    public float maxTurnAngle = 20f;
    public float carHorsePower = 400f;

    [Header("Wheel Colliders")]
    public WheelCollider wc_FrontLeft;
    public WheelCollider wc_FrontRight;
    public WheelCollider wc_BackLeft;
    public WheelCollider wc_BackRight;

    void Start()
    {
        
    }

    void Update()
    {
        currentVelocity = carBody.velocity;

        // Old Input System code to get Forward/Reverse Input
        accelerationInput = Input.GetAxis("Vertical");

        // Old Input System code to get Turn Input
        targetTurnInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 createdInput = new Vector3(0, 0, accelerationInput);
        Vector3 adjustedInput = Vector3.Normalize(transform.forward + createdInput);
        float DotProduct = Vector3.Dot(currentVelocity.normalized, adjustedInput);

        if( DotProduct < 0 )
        {
            // Brake
            wc_FrontLeft.brakeTorque = 1000f;
            wc_FrontRight.brakeTorque = 1000f;
            wc_BackLeft.brakeTorque = 1000f;
            wc_BackRight.brakeTorque = 1000f;

            // No accel
            wc_BackLeft.motorTorque = 0;
            wc_BackRight.motorTorque = 0;
            wc_FrontLeft.motorTorque = 0;
            wc_FrontRight.motorTorque = 0;
        }
        else
        {
            // No Brake
            wc_FrontLeft.brakeTorque = 0;
            wc_FrontRight.brakeTorque = 0;
            wc_BackLeft.brakeTorque = 0;
            wc_BackRight.brakeTorque = 0;

            // Accel 
            wc_BackLeft.motorTorque = accelerationInput * carHorsePower * -1;
            wc_BackRight.motorTorque = accelerationInput * carHorsePower * -1;
        }

        // Purely for Debugging
        string KeyPressed;
        if(accelerationInput > 0)
        {
            KeyPressed = "W";
        }
        else if(accelerationInput < 0)
        {
            KeyPressed = "S";
        }
        else
        {
            KeyPressed = "No Key Pressed";
        }
        Debug.Log("Input = " + adjustedInput + " ||| Velocity = " + currentVelocity.normalized + " ||| Dot Product = " +  DotProduct);
        // Purely for debugging


        // Applying Turn
        currentTurnInput = ApproachTargetValueWithIncrement(currentTurnInput, targetTurnInput, 0.07f);
        wc_FrontLeft.steerAngle = currentTurnInput * maxTurnAngle;
        wc_FrontRight.steerAngle = currentTurnInput * maxTurnAngle;
    }

    private float ApproachTargetValueWithIncrement(float currentValue, float targetValue, float increment)
    {
        if(currentValue == targetValue)
        {
            return currentValue;
        }
        else
        {
            if(currentValue < targetValue)
            {
                currentValue = currentValue + increment;
            }
            else
            {
                currentValue = currentValue - increment;
            }
        }
        return currentValue;
    }
}
