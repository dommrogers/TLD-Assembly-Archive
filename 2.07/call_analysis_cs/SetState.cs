using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SetState : MonoBehaviour
{
	public bool m_ActiveOnState;

	public string m_State;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnSetState(string state, bool active)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetState()
	{
	}
}
