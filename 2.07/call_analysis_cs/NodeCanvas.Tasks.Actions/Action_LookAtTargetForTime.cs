using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_LookAtTargetForTime : ActionTask
{
	public BBParameter<string> targetMissionObjectIdentifier;

	public float blendInPercent;

	public float blendOutPercent;

	public float frameTimeSeconds;

	public bool shouldRestoreCameraOrientation;

	public UITweener.Method tweenInMethod;

	public bool steeperCurvesIn;

	public UITweener.Method tweenOutMethod;

	public bool steeperCurvesOut;

	private float timeRemaining;

	private PlayerControlMode restoreControlMode;

	private Quaternion restoreCameraOrientation;

	private Quaternion cameraTargetOrientation;

	private float blendInTime;

	private float blendOutTime;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 22)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public Action_LookAtTargetForTime()
	{
	}
}
