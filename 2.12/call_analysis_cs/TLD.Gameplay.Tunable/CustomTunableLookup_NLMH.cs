using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_NLMH : CustomTunableLookup<CustomTunableNLMH, float>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = ".ctor")]
	public CustomTunableLookup_NLMH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
