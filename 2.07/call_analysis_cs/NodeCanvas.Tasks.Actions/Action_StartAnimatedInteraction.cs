using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_StartAnimatedInteraction : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public bool forceInteraction;

	public float waitBlackedOutDurationSeconds;

	private bool hasCalledDoWork;

	private float waitTimeRemainingSeconds;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	private void UpdateFade(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_StartAnimatedInteraction), Member = "CanStart")]
	[Calls(Type = typeof(Action_StartAnimatedInteraction), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[Calls(Type = typeof(Action_StartAnimatedInteraction), Member = "UpdateFade")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	private bool CanStart()
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void OnWorkDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_StartAnimatedInteraction()
	{
	}
}
