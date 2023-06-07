using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//鼠标移动视角脚本-unity 已可被使用暂无加入优化计划
public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
