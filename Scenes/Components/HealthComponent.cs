using Godot;
using System;

public partial class HealthComponent : Node2D
{
	[Export] public int MaxHealth;
	public int CurrentHealth;
	public override void _Ready()
	{
		InitializeHealth();
	}

	public void InitializeHealth()
	{
		CurrentHealth = MaxHealth;
	}

	public void Damage(int damage)
	{
		CurrentHealth -= damage;
		if(CurrentHealth <= 0)
		{
			GetParent().QueueFree();
		}
	}
}
