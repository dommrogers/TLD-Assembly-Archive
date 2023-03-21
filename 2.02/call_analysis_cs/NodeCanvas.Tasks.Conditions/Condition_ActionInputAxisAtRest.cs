using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ActionInputAxisAtRest : ConditionTask
{
	public InputManager.InputAxis axis;

	public InputManager.InputAxisState inputAxis;

	public float m_Deadzone;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CallsUnknownMethods(Count = 3)]
	private Vector2 GetAxisValue()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	private bool Test()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_ActionInputAxisAtRest()
	{
	}
}
