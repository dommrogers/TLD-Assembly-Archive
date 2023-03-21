using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_GetContainerItemCount : ActionTask
{
	public string containerName;

	public string measurableType;

	public GearItem item;

	public GearItem alternateItem;

	public string storeCountVar;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "OnExecute")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallsUnknownMethods(Count = 4)]
	private bool DoContainerCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_GetContainerItemCount()
	{
	}
}
