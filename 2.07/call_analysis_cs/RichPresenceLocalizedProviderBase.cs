using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public abstract class RichPresenceLocalizedProviderBase : RichPresenceProviderBase
{
	private class PresenceEqualityComparer : IEqualityComparer<PresenceType>
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(PresenceType x, PresenceType y)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(PresenceType x)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PresenceEqualityComparer()
		{
		}
	}

	protected Dictionary<PresenceType, string> m_PresenceLocKeys;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Dictionary<, >), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected RichPresenceLocalizedProviderBase()
	{
	}
}
