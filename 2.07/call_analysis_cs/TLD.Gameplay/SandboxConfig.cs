using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class SandboxConfig : SandboxBaseConfig
{
	public int m_NumFeats;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = ".ctor")]
	public SandboxConfig()
	{
	}
}
