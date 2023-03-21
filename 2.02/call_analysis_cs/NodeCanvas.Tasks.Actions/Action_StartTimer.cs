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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "get_info")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		set
		{
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStop()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	public Action_StartTimer()
	{
	}
}
