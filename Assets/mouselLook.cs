using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotatin = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotatin_ = mouseY;
        xRotatin = Mathf.Clamp(xRotatin, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotatin, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
