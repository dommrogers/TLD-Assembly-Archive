using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_ProportionalMaxItems : CustomTunableLookup<CustomTunableNLH, CustomTunableLookup_NLMH>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CustomTunableLookup_ProportionalMaxItems()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
