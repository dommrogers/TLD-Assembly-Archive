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
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "GetLodBias")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetDefaultLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public LodBias()
	{
	}
}
