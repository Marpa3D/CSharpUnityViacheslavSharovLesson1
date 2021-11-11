using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    // ”правление движением камеры от ¬€чеслава "Marpa3D" Ўарова

    private float mouseX;
    private float mouseY;

    [Header("„увствительность мыши")]
    private float sensitivityMouse = 150f;

    private float xRotation = 0f;

    [SerializeField] private Transform _player;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseMovement();
    }

    private void MouseMovement()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        _player.Rotate(Vector3.up * mouseX);
    }
}
