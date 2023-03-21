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
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int GetHashCode(PresenceType x)
		{
			return default(int);
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public PresenceEqualityComparer()
		{
		}
	}

	protected Dictionary<PresenceType, string> m_PresenceLocKeys;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected RichPresenceLocalizedProviderBase()
	{
	}
}
