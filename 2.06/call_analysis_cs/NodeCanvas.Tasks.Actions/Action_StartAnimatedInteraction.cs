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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanStart()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "OnUpdate")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void DoWork()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	private void OnWorkDone()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_StartAnimatedInteraction()
	{
	}
}
