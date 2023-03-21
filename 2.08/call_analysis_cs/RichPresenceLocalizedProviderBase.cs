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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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
