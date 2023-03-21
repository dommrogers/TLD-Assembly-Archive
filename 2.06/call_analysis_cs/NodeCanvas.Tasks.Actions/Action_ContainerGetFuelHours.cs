using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ContainerGetFuelHours : ActionTask
{
	public string containerName;

	public string fuelVar;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Container), Member = "GetHoursFuel")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private bool DoContainerCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ContainerGetFuelHours()
	{
	}
}
