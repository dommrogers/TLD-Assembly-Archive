using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_Distance : CustomTunableLookup<CustomTunableDistance, float>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = ".ctor")]
	public CustomTunableLookup_Distance()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
