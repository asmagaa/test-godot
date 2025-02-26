using Godot;
using System;

public partial class Gun : Node2D
{
	[Export] PackedScene bulletScn;
	[Export] float bulletSpead;
	[Export] float bulletsPerSecundes;
	[Export] float bulletDmg;

	float fire_rate;

	float timeToFire;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		fire_rate = 1;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(timeToFire > fire_rate)
		{
			Fire();
		}else{
			timeToFire += (float)delta;
		}
	}
	private void Fire()
	{
		RigidBody2D bullet = bulletScn.Instantiate<RigidBody2D>();
		bullet.Rotation = GlobalRotation;
		bullet.GlobalPosition = GlobalPosition;
		bullet.LinearVelocity = bullet.Transform.X * bulletSpead;
		GetTree().Root.AddChild(bullet);
		timeToFire = 0;
	}
}
