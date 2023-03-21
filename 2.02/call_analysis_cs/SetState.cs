using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SetState : MonoBehaviour
{
	public bool m_ActiveOnState;

	public string m_State;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnSetState(string state, bool active)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SetState()
	{
	}
}
