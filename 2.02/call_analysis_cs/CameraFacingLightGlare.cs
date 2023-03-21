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

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraFacingLightGlare()
	{
	}
}
