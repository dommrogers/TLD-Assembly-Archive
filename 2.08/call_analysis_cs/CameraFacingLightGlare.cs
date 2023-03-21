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
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public CameraFacingLightGlare()
	{
	}
}
