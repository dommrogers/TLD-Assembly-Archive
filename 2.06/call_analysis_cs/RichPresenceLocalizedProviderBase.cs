using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public abstract class RichPresenceLocalizedProviderBase : RichPresenceProviderBase
{
	private class PresenceEqualityComparer : IEqualityComparer<PresenceType>
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool Equals(PresenceType x, PresenceType y)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(PresenceType x)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PresenceEqualityComparer()
		{
		}
	}

	protected Dictionary<PresenceType, string> m_PresenceLocKeys;

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsUnknownMethods(Count = 11)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected RichPresenceLocalizedProviderBase()
	{
	}
}
