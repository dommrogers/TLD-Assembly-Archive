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
		[Calls(Type = typeof(float), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 21)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public Action_LookAtTargetForTime()
	{
	}
}
