using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 1.5f;

    private bool lerpCrouch;
    public static bool crouching;
    private bool sprinting;
    public float crouchTimer;

    [SerializeField]
    private GameObject studentModel;
    private bool isDropCoverHold = false;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;

            if (crouching)
            {
                //controller.height = Mathf.Lerp(controller.height, 1f, p);
                speed = 0;
                studentModel.GetComponent<Animator>().SetBool("isWalkWithHandsUp", false);
                isDropCoverHold = true;
                studentModel.GetComponent<Animator>().SetBool("isDropCoverHold", isDropCoverHold);
            }
            else
            {
                isDropCoverHold = false;
                studentModel.GetComponent<Animator>().SetBool("isDropCoverHold", isDropCoverHold);
                controller.height = Mathf.Lerp(controller.height, 2, p);
                speed = 3;
            }

            if(p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }


    }

    // receive the inputs for our InputManager.cs  and apply them to our character controller :)
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;

        if(isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        controller.Move(playerVelocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) && sprinting != true || Input.GetKey(KeyCode.A) && sprinting != true || Input.GetKey(KeyCode.S) && sprinting != true || Input.GetKey(KeyCode.D) && sprinting != true)
        {
            studentModel.GetComponent<Animator>().SetBool("isWalkWithHandsUp", true);
        }
        else
        {
            studentModel.GetComponent<Animator>().SetBool("isWalkWithHandsUp", false);
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            //playerVelocity.y = Mathf.Sqrt(jumpHeight * -0.5f * gravity);
        }
    }

    
    public void Crouch()
    {
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }
    

    public void Sprint()
    {
        if (crouching)
        {
            speed = 1;
        }
        else
        {
            sprinting = !sprinting;
            if (sprinting)
            {
                speed = 8;
                studentModel.GetComponent<Animator>().SetBool("isRunWithHandsUp", true);
            }
            else
            {
                speed = 3;
                studentModel.GetComponent<Animator>().SetBool("isRunWithHandsUp", false);
            }
        }

    }
}
