using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class Entitlement : ISettable
{
	private string _003CEntitlementName_003Ek__BackingField;

	private string _003CEntitlementId_003Ek__BackingField;

	private string _003CCatalogItemId_003Ek__BackingField;

	private int _003CServerIndex_003Ek__BackingField;

	private bool _003CRedeemed_003Ek__BackingField;

	private long _003CEndTimestamp_003Ek__BackingField;

	public string EntitlementName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string CatalogItemId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public int ServerIndex
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool Redeemed
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long EndTimestamp
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 15)]
		get
		{
			return default(long);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_Redeemed")]
	[CalledBy(Type = typeof(Entitlement), Member = "Set")]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_CatalogItemId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_EntitlementName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_EntitlementId")]
	internal void Set(EntitlementInternal? other)
	{
	}

	[Calls(Type = typeof(Entitlement), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Entitlement()
	{
	}
}
