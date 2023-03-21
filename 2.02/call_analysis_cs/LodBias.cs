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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public float GetLodBias(QualityLodBias quality)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "GetLodBias")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetDefaultLodBias(QualityLodBias quality)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LodBias()
	{
	}
}
