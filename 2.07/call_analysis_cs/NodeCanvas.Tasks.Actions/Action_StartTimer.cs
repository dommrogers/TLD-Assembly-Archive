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
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartTimer), Member = "get_realId")]
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
	[CallsUnknownMethods(Count = 3)]
	public Action_StartTimer()
	{
	}
}
