using Godot;
using System;
public partial class TowerFactory : Node2D
{
	[Export] public PackedScene tower_scn;
	[Export] public float speed;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
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
		//CharacterBody2D tower = tower_scn.Instantiate<CharacterBody2D>();
	//	GetTree().Root.AddChild(tower);
	}
}
