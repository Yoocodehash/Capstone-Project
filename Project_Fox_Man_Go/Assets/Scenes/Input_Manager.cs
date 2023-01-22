using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Manager : MonoBehaviour
{
   PlayerControllers playerControls;

    public Vector2 movementInput;


    // Start is called before the first frame update
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControllers();

          //  playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();

        }
    }
    // Update is called once per frame
   private void OnDisable()
    {
       // playerControls.Disable();
    }
}
