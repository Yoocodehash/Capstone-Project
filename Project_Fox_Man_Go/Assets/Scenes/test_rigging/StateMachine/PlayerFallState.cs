using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallState : PlayerBaseState, IRootState
{
    public PlayerFallState(PlayerStateMachine currentContext,
        PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {
        IsRootState = true;
       
    }

    public override void EnterState()
    {
        InitializeSubState();
        Ctx.Animator.SetBool("isFalling", true);
    }
    public override void UpdateState()
    {
        HandleGravity();
        CheckSwitchStates();
    }

    public override void ExitState()
    {
        Ctx.Animator.SetBool("isFalling", false);
    }

    public void HandleGravity()
    {
        float previousYVelocity = Ctx.CurrentMovementY;
        Ctx.CurrentMovementY = Ctx.CurrentMovementY + Ctx.Gravity * Time.deltaTime;
        Ctx.AppliedMovementY = Mathf.Max((previousYVelocity+ Ctx.CurrentMovementY) * .5f, -20.0f);
    }

    public override void CheckSwitchStates()
    {
        // if player is grounded switch to the grounded state
        if (Ctx.CharacterController.isGrounded)
        {
            SwitchState(Factory.Grounded());
        }
    }

    public override void InitializeSubState()
    {
     if(!Ctx.IsMovementPressed && !Ctx.IsRunPressed){
            SetSubState(Factory.Idle()); 
        }else if (Ctx.IsMovementPressed && !Ctx.IsRunPressed){
            SetSubState(Factory.Walk());
        }
        else
        {
            SetSubState(Factory.Run());
        }
    }
}
