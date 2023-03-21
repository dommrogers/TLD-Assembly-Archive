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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomStableThreshold()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public ActivationParameters()
	{
	}
}
