using Godot;
using System;

public partial class Attack : State
{
	[Export] public int DashSpeed;
	[Export] public CharacterBody2D enemy;
	[Export] public float moveSpeed = 60f;
	public Vector2 Direction;
	public CharacterBody2D player;
	public bool CanDash = true;
    public override void Enter()
    {
		player = (CharacterBody2D)GetTree().GetFirstNodeInGroup("Player");
    }
    public override void PhysicsUpdate(float delta)
    {
        Direction = player.GlobalPosition - enemy.GlobalPosition;
		Vector2 dashDirection = Direction.Normalized();
		enemy.Position *= dashDirection/DashSpeed;
    }

}
