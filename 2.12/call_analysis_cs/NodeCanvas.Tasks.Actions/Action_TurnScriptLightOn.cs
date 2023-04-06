using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_TurnScriptLightOn : ActionTask
{
	public BBParameter<string> scriptLightMissionId;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[CallsUnknownMethods(Count = 1)]
	private void TurnScriptLightOn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ScriptLight GetScriptLight(string moi)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_TurnScriptLightOn()
	{
	}
}
