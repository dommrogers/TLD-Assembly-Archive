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
		[CallsUnknownMethods(Count = 21)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_Spring), Member = "Stop")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public Action_LookAtTargetForTime()
	{
	}
}
