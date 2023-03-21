using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class DistanceParameters : ScriptableObject
{
	public float m_Fancy;

	public float m_Ultra;

	public float m_High;

	public float m_Medium;

	public float m_Low;

	public float m_FadePercent;

	[CallerCount(Count = 0)]
	public float GetCutoffDistance(QualityLodBias quality)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetFadeDistance(QualityLodBias quality)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DistanceParameters()
	{
	}
}
