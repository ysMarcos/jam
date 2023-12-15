using Godot;
using System;

public partial class HitboxComponent : Area2D
{
	[Export] HealthComponent HealthComponent;

	public void Damage(int damage)
	{
		HealthComponent?.Damage(damage);
	}
}
