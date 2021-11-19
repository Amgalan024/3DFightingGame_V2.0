﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Kick : State
{
    public Kick(Player player, StateMachine stateMachine, Animator animator, Rigidbody rigidbody, PlayerControls playerControls) : base(player, stateMachine, animator, rigidbody,  playerControls)
    {
    }
    public override void Enter()
    {
        //Animator.Play("Roundhouse Kick");
        Animator.SetBool("IsKicking", true);
        Player.IsAttacking = true;
        Player.SetDamage(Player.KickDamage);
    }
    public override void Exit()
    {
        Animator.SetBool("IsKicking", false);
    }
    public override void Update()
    {

    }
    public override void FixedUpdate()
    {
        if (!Player.IsAttacking)
        {
            StateMachine.ChangeState(StateMachine.PlayerStates.Idle);
        }
    }
}
