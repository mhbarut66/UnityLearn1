using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerNumber; // Bu değeri Inspector penceresinden ayarlayarak her oyuncunun numarasını belirleyebilirsiniz.

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Oyuncu numarasına göre girişleri alın
        if (playerNumber == 1)
        {
            // Klavye girişleri
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }
        else if (playerNumber == 2)
        {
            // Joystick girişleri
            horizontalInput = Input.GetAxis("JHorizontal");
            forwardInput = Input.GetAxis("JVertical");
        }

        // Hareketi ve dönüşü uygula
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
