using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct EntitlementInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_EntitlementName;

	private IntPtr m_EntitlementId;

	private IntPtr m_CatalogItemId;

	private int m_ServerIndex;

	private int m_Redeemed;

	private long m_EndTimestamp;

	public string EntitlementName
	{
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string CatalogItemId
	{
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int ServerIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool Redeemed
	{
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public long EndTimestamp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return 0L;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_EntitlementName")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_EntitlementId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_CatalogItemId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_Redeemed")]
	public void Set(Entitlement other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntitlementInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
