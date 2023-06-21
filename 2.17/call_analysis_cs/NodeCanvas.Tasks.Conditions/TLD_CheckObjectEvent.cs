using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_CheckObjectEvent : ConditionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	public BBParameter<string> missionObjectName;

	public MissionObjectClass missionObjectClass;

	public GameObject[] prefabTypes;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsUnknownMethods(Count = 2)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public TLD_CheckObjectEvent()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
