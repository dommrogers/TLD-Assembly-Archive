using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ContainerAllFoodIsNatural : ActionTask
{
	public string containerName;

	public string naturalVar;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Container), Member = "AllFoodItemsAreNatural")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private bool DoContainerCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ContainerAllFoodIsNatural()
	{
	}
}
