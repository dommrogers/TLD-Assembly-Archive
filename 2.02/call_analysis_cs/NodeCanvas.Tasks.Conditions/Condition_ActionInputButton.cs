using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ActionInputButton : ConditionTask
{
	public InputManager.InputAction action;

	public InputManager.InputState inputState;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CallsUnknownMethods(Count = 2)]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_ActionInputButton()
	{
	}
}
