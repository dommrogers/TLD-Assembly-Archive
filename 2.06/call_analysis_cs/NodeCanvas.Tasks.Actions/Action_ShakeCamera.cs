using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShakeCamera : ActionTask
{
	public float m_HorizontalShake;

	public float m_VerticalShake;

	public float m_DurationSeconds;

	public float m_WeaponShakeMultiplier;

	public float m_CameraRollMultiplier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_ShakeCamera()
	{
	}
}
