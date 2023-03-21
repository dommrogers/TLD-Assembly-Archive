using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_TimeOfDay : CustomTunableLookup<CustomTunableTimeOfDay, float>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CustomTunableLookup_TimeOfDay()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
