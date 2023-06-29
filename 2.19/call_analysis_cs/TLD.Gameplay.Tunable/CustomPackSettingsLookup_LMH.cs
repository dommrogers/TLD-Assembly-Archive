using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AI;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomPackSettingsLookup_LMH : CustomTunableLookup<CustomTunableLMH, PackSettings>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = ".ctor")]
	public CustomPackSettingsLookup_LMH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
