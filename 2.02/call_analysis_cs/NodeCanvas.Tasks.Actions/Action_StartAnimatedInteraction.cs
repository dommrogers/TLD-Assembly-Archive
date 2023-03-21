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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private bool CanStart()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 14)]
	private void DoWork()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnWorkDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_StartAnimatedInteraction()
	{
	}
}
