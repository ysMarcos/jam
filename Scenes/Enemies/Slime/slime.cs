using Godot;
using System;

public partial class Slime : CharacterBody2D
{
	[Export] public float Speed;
	public CharacterBody2D Player;
	public override void _Ready()
	{
		Player = (CharacterBody2D)GetTree().GetFirstNodeInGroup("Player");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Velocity = Position.DirectionTo(Player.Position) * Speed;
		MoveAndSlide();
	}

}
