using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// public class PlayerJump : MonoBehaviour
// {
//     public GroundCheck groundCheck;
//     public GameObject charModel;
    
//     public float jumpForce= 5;
//     public float gravity = 20;
//     public float gravityScale = 1;
//     float velocity;
    
//     void Update()
//     {
//         velocity += gravity * gravityScale * Time.deltaTime;
//         if (groundCheck.isGrounded && velocity < 0)
//         {
//             velocity = 0;
//         }
//         if (Input.GetKey(KeyCode.UpArrow))
//         {
//             velocity = jumpForce;
//             charModel.GetComponent<Animator>().Play("Jump");
//         }
//         transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        
//     }
// }