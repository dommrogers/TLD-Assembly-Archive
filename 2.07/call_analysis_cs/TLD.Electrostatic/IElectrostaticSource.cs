using Cpp2ILInjected.CallAnalysis;

namespace TLD.Electrostatic;

public interface IElectrostaticSource
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	float GetElectroStaticActive();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	float GetElectrostaticStrength();
}
