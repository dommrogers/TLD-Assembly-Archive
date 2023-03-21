using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class ActivationParameters : ScriptableObject
{
	public MinMax m_ActivationThreshold;

	public MinMax m_ActivationStable;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomActivationThreshold()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetRandomStableThreshold()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ActivationParameters()
	{
	}
}
