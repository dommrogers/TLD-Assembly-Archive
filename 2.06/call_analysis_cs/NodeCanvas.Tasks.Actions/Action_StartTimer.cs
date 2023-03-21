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
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		set
		{
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 12)]
	public Action_StartTimer()
	{
	}
}
