using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_NLMHV : CustomTunableLookup<CustomTunableNLMHV, float>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CustomTunableLookup_NLMHV()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
