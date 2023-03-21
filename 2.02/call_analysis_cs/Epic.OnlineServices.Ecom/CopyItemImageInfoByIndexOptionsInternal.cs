using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyItemImageInfoByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ItemId;

	private uint m_ImageInfoIndex;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ItemId
	{
		[CalledBy(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint ImageInfoIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "set_ItemId")]
	public void Set(CopyItemImageInfoByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyItemImageInfoByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "set_ItemId")]
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
