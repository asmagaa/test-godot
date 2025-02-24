using Godot;
using System;
using System.Net.Http.Headers;
using System.Threading;
public partial class TowerPlacer  : Node2D
{
	[Export] public PackedScene tower_scn;
	[Export] public float speed;
	// Called when the node enters the scene tree for the first time.
	public CharacterBody2D player;
	public Area2D areaOfPlacer;
	public override void _Ready()
	{
		player = GetParent().GetNode<CharacterBody2D>("player");
		areaOfPlacer = GetNode<Area2D>("Area2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
				if(Input.IsActionJustPressed("place_tower"))
		{
			PlaceTower();
		}
	}
		void PlaceTower()
	{
		if(player != null && areaOfPlacer.OverlapsBody(player))
		{
			PackedScene scene = ResourceLoader.Load<PackedScene>("res://Tower.tscn");
			Node instance = scene.Instantiate();
			AddChild(instance);
		}

		// CharacterBody2D tower = tower_scn.Instantiate<CharacterBody2D>();
		// Vector2 position = tower.Position;
		// position.Y = this.Position.Y;
		// position.X = this.Position.Y;
		// tower.Position = position;
		// AddChild(tower);
		
	}
}
