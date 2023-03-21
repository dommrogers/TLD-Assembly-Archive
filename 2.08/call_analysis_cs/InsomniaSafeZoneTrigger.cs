using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using UnityEngine;

public class InsomniaSafeZoneTrigger : MonoBehaviour
{
	public static LogFilter s_LogFilter;

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InsomniaSafeZoneTrigger()
	{
	}
}
