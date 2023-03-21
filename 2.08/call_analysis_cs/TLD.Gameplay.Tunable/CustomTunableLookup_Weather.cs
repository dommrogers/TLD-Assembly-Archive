using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_Weather : CustomTunableLookup<CustomTunableWeather, float>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CustomTunableLookup_Weather()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
