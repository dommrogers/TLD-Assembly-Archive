using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Tunable;

[Serializable]
public class CustomTunableLookup_NLH : CustomTunableLookup<CustomTunableNLH, float>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = ".ctor")]
	public CustomTunableLookup_NLH()
	{
		((CustomTunableLookup<, >)(object)this)._002Ector();
	}
}
