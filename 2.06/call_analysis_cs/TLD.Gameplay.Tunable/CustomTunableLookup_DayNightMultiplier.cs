using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_DayNightMultiplier : CustomTunableLookup<CustomTunableDayNightMultiplier, float>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CustomTunableLookup_DayNightMultiplier()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
