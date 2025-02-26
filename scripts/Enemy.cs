using Godot;
using System;
using System.Diagnostics;

public partial class Enemy : CharacterBody2D
{

	[Export] float damage ;
	[Export] float speed;
	[Export] float aps; // attac per s

	float attacSpeed;
	float timeToAttac;
	bool inAttackRange = false;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

		public override void _Ready()
	{
		attacSpeed = 1 / aps;
		timeToAttac = 0;
	}
	public override void _PhysicsProcess(double delta)
	{
		if(inAttackRange)
		{
			if(timeToAttac >= attacSpeed)
			{
				Attack();
				timeToAttac = 0;
			}else{
				timeToAttac += (float)delta;
			}
		}
		VerticalUpdate(delta);
     	HorizontalUpdate();  
	}
    public void Attack()
	{
		//Debug.Print("123");
	}
    void VerticalUpdate(double delta)
    {
        Vector2 velocity = Velocity;
        if (!IsOnFloor())
		{
			velocity.Y += gravity * (float)delta;
		}

       Velocity = velocity;
       MoveAndSlide();
    }

    void HorizontalUpdate()
    {  
		
        Vector2 velocity = Velocity;
		float horizontalMovement = 1;
		if (horizontalMovement != 0)
		{
			velocity.X = horizontalMovement * speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(velocity.X, 0, speed);
		}
        Velocity = velocity;
        MoveAndSlide();
    }
}
