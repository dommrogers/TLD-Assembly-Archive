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

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public CameraFacingLightGlare()
	{
	}
}
