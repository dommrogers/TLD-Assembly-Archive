using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ActionInputAxisAtRest : ConditionTask
{
	public InputManager.InputAxis axis;

	public InputManager.InputAxisState inputAxis;

	public float m_Deadzone;

	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[CallerCount(Count = 0)]
	private Vector2 GetAxisValue()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CallsUnknownMethods(Count = 1)]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_ActionInputAxisAtRest()
	{
	}
}
