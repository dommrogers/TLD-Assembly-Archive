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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		set
		{
		}
	}

	public string CatalogItemId
	{
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
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
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool Redeemed
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Entitlement), Member = "Set")]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
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
			return default(long);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_EntitlementName")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_EntitlementId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_CatalogItemId")]
	[Calls(Type = typeof(EntitlementInternal), Member = "set_Redeemed")]
	[CalledBy(Type = typeof(EntitlementInternal), Member = "Set")]
	public void Set(Entitlement other)
	{
	}

	[Calls(Type = typeof(EntitlementInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
