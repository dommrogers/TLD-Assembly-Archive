using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_DayNightMultiplier : CustomTunableLookup<CustomTunableDayNightMultiplier, float>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CustomTunableLookup_DayNightMultiplier()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
