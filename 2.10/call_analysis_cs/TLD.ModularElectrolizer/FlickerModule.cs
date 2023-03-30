using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.ModularElectrolizer;

[Serializable]
public class FlickerModule
{
	public FlickerValueGenerator m_ValueGenerator;

	public FlickerAmplitudeParameters m_AmplitudeModifier;

	public FlickerTemporalParameters m_TemporalModifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FlickerModule()
	{
	}
}
