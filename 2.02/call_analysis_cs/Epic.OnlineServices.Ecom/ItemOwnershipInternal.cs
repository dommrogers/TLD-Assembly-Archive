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
		[CalledBy(Type = typeof(ItemOwnership), Member = "Set")]
		[CalledBy(Type = typeof(ItemOwnership), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ItemOwnershipInternal), Member = "Set")]
		[CalledBy(Type = typeof(ItemOwnershipInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public OwnershipStatus OwnershipStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(ItemOwnershipInternal), Member = "set_Id")]
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
