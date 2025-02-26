using Godot;
using System;

public partial class EnemyHealth : Node2D
{
	[Export] public float maxHealth = 100f; 
	float health;
	private CharacterBody2D enemy;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		health = maxHealth;
		//enemy = this.GetParent<CharacterBody2D>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void Damage(float damage)
	{
		health -= damage;
		if(health <=0)
		{

		}
	}
}
