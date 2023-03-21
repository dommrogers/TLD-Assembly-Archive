using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public sealed class AmplifyBloomEffect : AmplifyBloomBase
{
	[Calls(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AmplifyBloomEffect()
	{
	}
}
