using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class State : Node
{
	public FSM fsm;
	public virtual void Enter() {}
	public virtual void Exit() {}
	public virtual void StateReady() {}
	public virtual void Update(float delta) {}
	public virtual void PhysicsUpdate(float delta) {}
	public virtual void HandleInput(InputEvent @event) {}
}
