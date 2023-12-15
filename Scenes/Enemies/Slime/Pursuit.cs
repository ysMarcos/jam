using Godot;
using System;

public partial class Pursuit : State
{
	[Export] public CharacterBody2D enemy;
	[Export] public float moveSpeed = 60f;
	public CharacterBody2D player;
    public override void Enter()
    {
        player = (CharacterBody2D)GetTree().GetFirstNodeInGroup("Player");
    }
	public override void PhysicsUpdate(float delta) {
		Vector2 direction = player.GlobalPosition - enemy.GlobalPosition;
		if (direction.Length() > 25)
		{
			enemy.Position += direction/moveSpeed;
		}
		else
		{
			enemy.Velocity = new Vector2();
		}
	}

	private void OnBodyEntered(Node2D body)
	{
		if(body == player){
			fsm.TransitionTo("Attack");
		}
	}
}
