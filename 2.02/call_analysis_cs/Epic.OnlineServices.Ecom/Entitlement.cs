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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string CatalogItemId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public int ServerIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return false;
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Entitlement), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_EntitlementName")]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_EntitlementId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_CatalogItemId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "get_Redeemed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void Set(EntitlementInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Entitlement), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Entitlement()
	{
	}
}
