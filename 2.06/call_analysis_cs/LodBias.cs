using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LodBias : MonoBehaviour
{
	public static float DEFAULT_LODBIAS_PCLOW;

	public static float DEFAULT_LODBIAS_PCMEDIUM;

	public static float DEFAULT_LODBIAS_PCHIGH;

	public static float DEFAULT_LODBIAS_PCULTRA;

	public static float DEFAULT_LODBIAS_PCFANCY;

	public float m_PcLowBias;

	public float m_PcMediumBias;

	public float m_PcHighBias;

	public float m_PcUltraBias;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public float GetLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static float GetDefaultLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public LodBias()
	{
	}
}
