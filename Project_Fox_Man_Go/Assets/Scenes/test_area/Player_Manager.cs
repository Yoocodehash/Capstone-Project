using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    Input_Manager inputManager;
    CameraManager cameraManager;
    Player_Locomotion playerLocomotion;

    // Start is called before the first frame update
    private void Awake()
    {
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
        cameraManager.FollowTarget();
    }
}
