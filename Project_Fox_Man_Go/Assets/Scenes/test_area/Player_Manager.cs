using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    Animator animator;
    Input_Manager inputManager;
    CameraManager cameraManager;
    Player_Locomotion playerLocomotion;

    public bool isInteracting;

    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<Input_Manager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerLocomotion = GetComponent<Player_Locomotion>();
    }

    // Update is called once per frame
    private void Update()
    {
        inputManager.HandleAllInputs();
    }
    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();

        isInteracting = animator.GetBool("IsInteracting");
        playerLocomotion.isJumping = animator.GetBool("isJumping");
        animator.SetBool("isGrounded", playerLocomotion.isGrounded);

    }
}
