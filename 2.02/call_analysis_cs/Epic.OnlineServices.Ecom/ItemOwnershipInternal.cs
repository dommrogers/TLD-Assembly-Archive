using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct ItemOwnershipInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Id;

	private OwnershipStatus m_OwnershipStatus;

	public string Id
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ItemOwnership), Member = "Set")]
		[CalledBy(Type = typeof(ItemOwnership), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ItemOwnershipInternal), Member = "Set")]
		[CalledBy(Type = typeof(ItemOwnershipInternal), Member = "Set")]
		set
		{
		}
	}

	public OwnershipStatus OwnershipStatus
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		get
		{
			return default(OwnershipStatus);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemOwnershipInternal), Member = "set_Id")]
	public void Set(ItemOwnership other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ItemOwnershipInternal), Member = "set_Id")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
