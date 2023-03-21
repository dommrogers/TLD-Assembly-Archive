using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_NLMHV : CustomTunableLookup<CustomTunableNLMHV, float>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CustomTunableLookup_NLMHV()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
