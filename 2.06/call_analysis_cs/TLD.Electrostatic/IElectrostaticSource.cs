using Cpp2ILInjected.CallAnalysis;

namespace TLD.Electrostatic;

public interface IElectrostaticSource
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	float GetElectroStaticActive();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	float GetElectrostaticStrength();
}
