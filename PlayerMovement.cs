using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float m_speed = 5f;
   

    // Update is called once per frame
    void Update()
    {
        PlayerMovement_KeyTransform();
    }
    public void PlayerMovement_KeyTransform()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            Player.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            Player.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Translate(Vector3.right * -m_speed * Time.deltaTime);
        }

    }
}
