using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetItemImageInfoCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ItemId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ItemId
	{
		[CalledBy(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "set_ItemId")]
	public void Set(GetItemImageInfoCountOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "GetItemImageInfoCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "set_ItemId")]
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
