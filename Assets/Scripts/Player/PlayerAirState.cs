using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{
    public PlayerAirState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if(player.IsWallDetected() )
        {
            player.stateMachine.ChangeState(player.wallSlideState);
        }

        if(player.IsGroundDetected()) 
        {
            player.stateMachine.ChangeState(player.idleState);  
        }

        if(xInput != 0)
        {
            player.SetVelocity(player.moveSpeed * .8f * xInput, player.rb.velocity.y);
        }
    }
}
