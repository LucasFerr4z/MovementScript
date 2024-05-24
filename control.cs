using UnityEngine;

public class PlayerMovement :
MonoBehavior
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = 
Vector3.zero;
    private CharacterController
controller;

    void Start()
    {
        controller =
GetComponent<CharacterController>();
    }

    void Update()
    {
            if (controller.isGrounded)
        {

            float moveHorizontal = Input.GetAxis("Horizontal");
Input.GetAxis("Horizontal");
            float moveVertical =
Input.GetAxis("Vertical");

            moveDirection = new
Vector3(moveHorizontal, 0.0f,
moveVertical);
            moveDirection = 
transform.TransformDirection(moveDirec
tion);
            moveDirection *= speed;

            if
(Input.GetButton("Jump"))
                {
                    moveDirection.y =
jumpSpeed;
                }
        }
        moveDirection.y -= gravity *
Time.deltaTime;

      controller.Move(moveDirection
* Time.deltaTime);
        
    }
}