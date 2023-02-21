using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class FireBall : MonoBehaviour
{
    public Transform projectilePoint;
    public GameObject fireballprefab;
    public float fireballspeed = 10;

    //  PlayerInput playerInput;
    //  CharacterController characterController;
   /// Animator animator;

    //int isAttackHash;

   // void Awake()
   // {
      //  isAttackHash = Animator.StringToHash("isAttack");
    //}

    void Update()
    {
        //bool isAttacking = animator.GetBool(isAttackHash);

        if (Input.GetButtonDown("Fire1"))
        {
            var magic = Instantiate(fireballprefab, projectilePoint.position, projectilePoint.rotation);
            magic.GetComponent<Rigidbody>().velocity = projectilePoint.forward * fireballspeed;
           // animator.SetBool(isAttackHash, true);
        }
      //  else
      //  {
       //     animator.SetBool(isAttackHash, false);
       // }
    }
/*
    void OnEnable()
    {
        //enable the character controls action map
        playerInput.CharacterControls.Enable();
    }

    void OnDisable()
    {
        //disable the character controls action map
        playerInput.CharacterControls.Disable();
    }
*/
}
