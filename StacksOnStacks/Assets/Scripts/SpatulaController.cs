using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeSpatula : MonoBehaviour
{

    public Rigidbody spatulaRigidbody;
    public float rotationSpeed = 50.0f;
    public float maxRotationAngle = 90.0f;
    public float returnSpeed = 10.0f;
    public float moveSpeed = 5.0f;
    private bool isCharging = false;
    private bool isFlipping = false;
    private float chargeTimer = 0.0f;
    private float flipTimer = 0.0f;
    private float rotateAmountX = 0.0f;
    private float flipAmountZ = 0.0f;
    private float rotateAmountY = 0.0f;

    private Quaternion originalRotation;
    private Quaternion targetRotation;

    private void Start()
    {
        originalRotation = spatulaRigidbody.rotation;
        targetRotation = originalRotation;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            isCharging = true;
            chargeTimer += Time.deltaTime;
        }
        else if (isCharging)
        {
            isCharging = false;
            isFlipping = true;
            ApplyRotation(chargeTimer);
            chargeTimer = 0.0f;

            StartCoroutine(ResetZAxisRotation());
        }

        if (isFlipping)
        {
            flipTimer += Time.deltaTime;
            if (flipTimer >= returnSpeed)
            {
                isFlipping = false;
                flipTimer = 0.0f;
                flipAmountZ = 0.0f;
            }
        }

        if (Input.GetKey(KeyCode.T)) 
        {
            rotateAmountY += rotationSpeed * Time.deltaTime;
        }

            if (Input.GetKey(KeyCode.Q))
        {
            rotateAmountX += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            rotateAmountX -= rotationSpeed * Time.deltaTime;
        }

        targetRotation = Quaternion.Euler(originalRotation.eulerAngles + new Vector3(rotateAmountX, rotateAmountY, flipAmountZ));

        spatulaRigidbody.MoveRotation(Quaternion.Slerp(spatulaRigidbody.rotation, targetRotation, returnSpeed * Time.deltaTime));

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 newPosition = spatulaRigidbody.position + moveDirection * moveSpeed * Time.deltaTime;
        spatulaRigidbody.MovePosition(newPosition);
    }

    private void ApplyRotation(float chargeAmount)
    {
        float rotationAngle = Mathf.Lerp(0, -maxRotationAngle, chargeAmount);

        flipAmountZ += rotationAngle;

        flipAmountZ = Mathf.Clamp(flipAmountZ, -maxRotationAngle, maxRotationAngle);
    }

    private IEnumerator ResetZAxisRotation()
    {
        yield return new WaitForSeconds(1.3f);

        flipAmountZ = 0.0f;
    }
}