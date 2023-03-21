using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ContainerGetFuelHours : ActionTask
{
	public string containerName;

	public string fuelVar;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Container), Member = "GetHoursFuel")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 4)]
	private bool DoContainerCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_ContainerGetFuelHours()
	{
	}
}
