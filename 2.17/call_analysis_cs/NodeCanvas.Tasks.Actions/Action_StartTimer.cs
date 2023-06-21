using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_StartTimer : ActionTask
{
	public string id;

	public BBParameter<string> bbID;

	public bool isRealtime;

	public bool isCountdown;

	public bool showOnHUD;

	public BBParameter<float> durationHrs;

	public BBParameter<string> eventOnExpire;

	public bool removeOnExpire;

	public bool scopeToState;

	public bool accountsLoadingTime;

	private string realId
	{
		[CalledBy(Type = typeof(Action_StartTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	public Action_StartTimer()
	{
	}
}
