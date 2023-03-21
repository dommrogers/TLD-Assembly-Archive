using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ActionInputAxisAtRest : ConditionTask
{
	public InputManager.InputAxis axis;

	public InputManager.InputAxisState inputAxis;

	public float m_Deadzone;

	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[CallsUnknownMethods(Count = 1)]
	private Vector2 GetAxisValue()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	private bool Test()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_ActionInputAxisAtRest()
	{
	}
}
