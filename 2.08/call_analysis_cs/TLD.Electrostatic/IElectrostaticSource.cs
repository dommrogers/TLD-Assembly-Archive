using Cpp2ILInjected.CallAnalysis;

namespace TLD.Electrostatic;

public interface IElectrostaticSource
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	float GetElectroStaticActive();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	float GetElectrostaticStrength();
}
