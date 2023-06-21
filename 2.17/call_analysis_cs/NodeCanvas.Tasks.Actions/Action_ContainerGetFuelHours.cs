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

	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[Calls(Type = typeof(Container), Member = "GetHoursFuel")]
	[Calls(Type = typeof(Variable<>), Member = "set_value")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool DoContainerCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ContainerGetFuelHours()
	{
	}
}
