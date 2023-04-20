using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BlendLightColor : MonoBehaviour
{
	private Color m_BaseColor;

	private float m_BlendBias;

	private Light m_Light;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetLightColor(Color color)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BlendLightColor()
	{
	}
}
