using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;

public class ElectrostaticEventListener : MonoBehaviour
{
	private UnityEvent<bool> m_ActiveChanged;

	private UnityEvent<bool> m_FullyActiveChanged;

	private UnityEvent<float> m_NormalizedActiveChanged;

	private UnityEvent<float> m_StrengthChanged;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 38)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ElectrostaticEventListener()
	{
	}
}
