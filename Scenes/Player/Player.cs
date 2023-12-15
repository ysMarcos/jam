using Godot;
using System;
[GlobalClass]
public partial class Player : CharacterBody2D
{
	public Vector2 input = Vector2.Zero;
	public float Speed = 800f;
    public override void _PhysicsProcess(double delta)
    {
        PlayerMovement();
    }
    public Vector2 GetInput()
	{
		input = Input.GetVector("left", "right", "up", "down");
		return input.Normalized();
	}

	public void PlayerMovement()
	{
		input = GetInput();
		Velocity = input * Speed;
		MoveAndSlide();
	}
}
