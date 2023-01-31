using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationAndMovementController : MonoBehaviour
{
    GamePads gamepads;
    CharacterController characterController;
    private Animator animator;

    int isWalkingHash;
    int isRunningHash;

    Vector2 currentMovementInput;
    Vector3 currentMovement;
    Vector3 currentRunMovement;
    bool isMovementPressed;
    bool isRunPressed; //depend is game slow add dash
    float rotationFactorPerframe = 15.0f;
    float runMultiplier = 3.0f;

    void Awake()
    {
        gamepads = new GamePads();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

        gamepads.CharacterControls.Move.started += onMovementInput;
        gamepads.CharacterControls.Move.canceled += onMovementInput;
        gamepads.CharacterControls.Move.performed += onMovementInput;
        gamepads.CharacterControls.Run.started += onRun;
        gamepads.CharacterControls.Run.canceled += onRun;
    }

    void onRun (InputAction.CallbackContext context)
     {
         isRunPressed = context.ReadValueAsButton();
     }

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
        currentMovement.x = currentMovementInput.x = runMultiplier;
        currentMovement.y = currentMovementInput.y = runMultiplier;
        isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;
    }

    void handleAnimation()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
      
        if (isMovementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isMovementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if ((isMovementPressed && isRunPressed) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        else if ((!isMovementPressed || !isRunPressed) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }

    void handleGravity()
    {
        if (characterController.isGrounded)
        {
            float groundedGravity = -0.05f;
            currentMovement.y = groundedGravity;
            currentRunMovement.y = groundedGravity;

        }else {
            float gravity = -9.8f;
            currentMovement.y += gravity;
            currentRunMovement.x += gravity;
            currentRunMovement.y += gravity;
            currentRunMovement.z += gravity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        handleRotation();
        handleAnimation();
        characterController.Move(currentMovement * Time.deltaTime);

        if (isRunPressed)
        {
            characterController.Move(currentMovement * Time.deltaTime);
        }
        else
        {
            characterController.Move(currentMovement * Time.deltaTime);
        }
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
