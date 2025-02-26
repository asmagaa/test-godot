using Godot;
using System;


public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

		public override void _Ready()
	{

	}
	public override void _PhysicsProcess(double delta)
	{
        HorizontalUpdate();
        VerticalUpdate(delta);
        
	}


    void VerticalUpdate(double delta)
    {
        Vector2 velocity = Velocity;
       	if (Input.IsActionJustPressed("jump") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		} 
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
		float horizontalMovement = Input.GetAxis("left", "right");
		if (horizontalMovement != 0)
		{
			velocity.X = horizontalMovement * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(velocity.X, 0, Speed);
		}
        Velocity = velocity;
        MoveAndSlide();
    }
}
