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

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	private bool CanStart()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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
