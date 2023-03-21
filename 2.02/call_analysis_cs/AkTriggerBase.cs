using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkTriggerBase : MonoBehaviour
{
	public delegate void Trigger(GameObject in_gameObject);

	public Trigger triggerDelegate;

	[CalledBy(Type = typeof(AkTriggerHandler), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AkUtilities.ShortIDGenerator), Member = "Compute")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 25)]
	public static Dictionary<uint, string> GetAllDerivedTypes()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected AkTriggerBase()
	{
	}
}
