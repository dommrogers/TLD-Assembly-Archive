using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_LMH : CustomTunableLookup<CustomTunableLMH, float>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = ".ctor")]
	public CustomTunableLookup_LMH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
