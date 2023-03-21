using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public sealed class AmplifyBloomEffect : AmplifyBloomBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	public AmplifyBloomEffect()
	{
	}
}
