using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraLodBiasOverride : MonoBehaviour
{
	private float m_LodBias;

	private float m_LastLodBias;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetLodBias(float lodBias)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPreCull()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPostRender()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraLodBiasOverride()
	{
	}
}
