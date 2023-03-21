using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public abstract class RichPresenceLocalizedProviderBase : RichPresenceProviderBase
{
	protected Dictionary<PresenceType, string> m_PresenceLocKeys;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public override void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected RichPresenceLocalizedProviderBase()
	{
	}
}
