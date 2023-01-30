using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationAndMovementController : MonoBehaviour
{
    GamePads gamepads;
    CharacterController characterController;
    private Animator animator;

    int isRunningHash;
   // int isJumpingHash;

    Vector2 currentMovementInput;
    Vector3 currentMovement;
    bool isMovementPressed;
   // bool isRunPressed; //depend is game slow add dash
    float rotationFactorPerframe = 15.0f;

    void Awake()
    {
        gamepads = new GamePads();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        isRunningHash = Animator.StringToHash("isRunning");
        //isJumpingHash = Animator.StringToHash("isJumping");

        gamepads.CharacterControls.Move.started += onMovementInput;
        gamepads.CharacterControls.Move.canceled += onMovementInput;
        gamepads.CharacterControls.Move.performed += onMovementInput;
        //gamepads.CharacterControls.Run.started += onRun;
    }

   // void onRun (InputAction.CallbackContext context)
   // {
   //     isRunPressed = context.ReadValueAsButton();
  //  }

    void handleRotation()
    {
        Vector3 positionToLookAt;

        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentMovement.z;

        Quaternion currentRotation = transform.rotation;

       

        if (isMovementPressed)
        {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation,targetRotation, rotationFactorPerframe * Time.deltaTime);
        }
    }

    void onMovementInput (InputAction.CallbackContext context)
    {
        currentMovementInput = context.ReadValue<Vector2>();
        currentMovement.x = currentMovementInput.x;
        currentMovement.z = currentMovementInput.y;
        isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;
    }

    void handleAnimation()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool iJumping = animator.GetBool("isJumping");

        if (isMovementPressed && !isRunning)
        {
            animator.SetBool("isRunning", true);
        }

        if (isMovementPressed && !isRunning)
        {
            animator.SetBool("isRunning", false);
        }
    }

    void handleGravity()
    {
        if (characterController.isGrounded)
        {
            float groundedGravity = -0.05f;
            currentMovement.y = groundedGravity;
        }
        else {
            float gravity = -9.8f;
            currentMovement.y += gravity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        handleRotation();
        handleAnimation();
        characterController.Move(currentMovement * Time.deltaTime);
    }

    void OnEnable()
    {
        gamepads.CharacterControls.Enable();
    }

    void OnDisable()
    {
        gamepads.CharacterControls.Disable();
    }
}
