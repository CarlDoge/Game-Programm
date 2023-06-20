using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpspeed = 5f;
    public float gravity = 20f;

    private CharacterController _characterController;
    private Vector3 _moveDirection = Vector3.zero;
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if(_characterController.isGrounded)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            _moveDirection = new Vector3(h, 0, v);
            if (Input.GetButton("jump"))
            _moveDirection.y = jumpspeed;
            
        }
        _moveDirection.y -= gravity * Time.deltaTime;
        _characterController.Move(_moveDirection * movespeed * Time.deltaTime);
    }
}
