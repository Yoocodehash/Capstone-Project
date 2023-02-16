using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRelativeMovement : MonoBehaviour
{
    float _horizontalInput;
    float _verticalInput;
    Vector3 _playerInput;
    [SerializeField]CharacterController _characterController;

    void Start()
    {
        //get the Character Controller component attached to the character
        _characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        //get and store player input every frame
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        // set it to the x and z values of the Vector3
        _playerInput.x = _horizontalInput;
        _playerInput.z = _verticalInput;

        // transform position using move and the player input Vector3
        _characterController.Move(_playerInput * Time.deltaTime);
    }
}
