using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_LMH : CustomTunableLookup<CustomTunableLMH, float>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CustomTunableLookup_LMH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
