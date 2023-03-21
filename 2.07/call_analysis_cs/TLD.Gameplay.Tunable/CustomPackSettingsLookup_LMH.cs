using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomPackSettingsLookup_LMH : CustomTunableLookup<CustomTunableLMH, PackSettings>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public CustomPackSettingsLookup_LMH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
