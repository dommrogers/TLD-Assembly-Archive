using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyItemByIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ItemId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyItemByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemByIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string ItemId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyItemByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemByIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemByIdOptionsInternal), Member = "set_ItemId")]
	public void Set(CopyItemByIdOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyItemById")]
	[Calls(Type = typeof(CopyItemByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemByIdOptionsInternal), Member = "set_ItemId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
