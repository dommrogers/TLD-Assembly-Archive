using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraFacingLightGlare : MonoBehaviour
{
	private enum EasingMode
	{
		Linear,
		Quadratic,
		Cubic
	}

	private float m_FacingThreshold;

	private float m_FalloffStart;

	private float m_FalloffRange;

	private EasingMode m_EasingMode;

	private CameraEffects.BloomOverride m_BloomOverride;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 26)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraFacingLightGlare()
	{
	}
}
