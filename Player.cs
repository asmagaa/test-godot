using Godot;
using System;
using System.Numerics;

public partial class Player : Node2D
{
	const float Movedis = 5;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Left) || Input.IsKeyPressed(Key.A))
		{
			this.Position += new Godot.Vector2(-Movedis, 0);
		}
		if (Input.IsKeyPressed(Key.Right) || Input.IsKeyPressed(Key.D))
		{
			this.Position += new Godot.Vector2(Movedis, 0);

		}
		if (Input.IsKeyPressed(Key.Up) || Input.IsKeyPressed(Key.W))
		{
			this.Position += new Godot.Vector2(0, -Movedis);

		}
		if (Input.IsKeyPressed(Key.Down) || Input.IsKeyPressed(Key.S))
		{
			this.Position += new Godot.Vector2(0, Movedis);

		}
	}
}
