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
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsUnknownMethods(Count = 36)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 33)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ElectrostaticEventListener()
	{
	}
}
