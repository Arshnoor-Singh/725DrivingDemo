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
    private bool isNitrousActive;

    public Rigidbody carBody;
    public float maxTurnAngle = 20f;
    public float carHorsePower = 400f;

    [Header("Nitrous Variables")]
    public float nitrousActiveDuration = 4f;
    public float nitrousRechargeTime = 10f;
    public float nirousRechargeDelay = 3f;
    public float nitrousTorque = 500f;

    private float currentNitrousCapacity = 1f;
    private float currentNitrousDelay = 0;
    private float currentNitrousTorque = 0;

    [Header("Wheel Colliders")]
    public WheelCollider wc_FrontLeft;
    public WheelCollider wc_FrontRight;
    public WheelCollider wc_BackLeft;
    public WheelCollider wc_BackRight;

    public void IANitrous(InputAction.CallbackContext context)
    {
        if(context.started == true)
        {
            isNitrousActive = true;
        }

        if(context.canceled == true)
        {
            isNitrousActive = false;
        }

    }

    void Update()
    {
        currentVelocity = carBody.velocity;

        // Old Input System code to get Forward/Reverse Input
        accelerationInput = Input.GetAxis("Vertical");

        // Old Input System code to get Turn Input
        targetTurnInput = Input.GetAxis("Horizontal");

        // Old input system code to get Nitrous Input
        isNitrousActive = Input.GetKey(KeyCode.N);


        // Checks if the nitrous button is pressed
        if(isNitrousActive == true)
        {
            // Makes sure nitrous isn't already empty
            if(currentNitrousCapacity > 0)
            {
                currentNitrousCapacity -= (Time.deltaTime/nitrousActiveDuration);
                currentNitrousTorque = nitrousTorque;
            }
            // The following else executes if Nitrous was held or pressed when the Nitrous capacity was already empty
            else
            {
                
            }
        }
        // When the button is not pressed, start Refilling Nitrous
        else
        {
            // Before refilling check to make sure you're not already full
            if(currentNitrousCapacity < 1)
            {
                currentNitrousCapacity += (Time.deltaTime / nitrousRechargeTime);
                currentNitrousTorque = 0;
            }
        }

        Debug.Log(" Current Nitrous Capacity " + currentNitrousCapacity);

    }

    private void FixedUpdate()
    {
        Vector3 combinedInput = (transform.forward * -1) * accelerationInput;
        float DotProduct = Vector3.Dot(currentVelocity.normalized, combinedInput);

        if( DotProduct < 0 ) // BRAKING
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
        else // FORWARD OR BACKWARDS
        {
            // No Brake
            wc_FrontLeft.brakeTorque = 0;
            wc_FrontRight.brakeTorque = 0;
            wc_BackLeft.brakeTorque = 0;
            wc_BackRight.brakeTorque = 0;

            // Accel 
            wc_BackLeft.motorTorque = ((accelerationInput * carHorsePower) + currentNitrousTorque) * -1;
            wc_BackRight.motorTorque = ((accelerationInput * carHorsePower) + currentNitrousTorque) * -1;
        }

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
