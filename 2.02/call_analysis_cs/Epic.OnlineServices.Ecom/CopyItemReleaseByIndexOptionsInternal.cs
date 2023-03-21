using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyItemReleaseByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ItemId;

	private uint m_ReleaseIndex;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string ItemId
	{
		[CalledBy(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public uint ReleaseIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "set_ItemId")]
	public void Set(CopyItemReleaseByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "set_ItemId")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyItemReleaseByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
