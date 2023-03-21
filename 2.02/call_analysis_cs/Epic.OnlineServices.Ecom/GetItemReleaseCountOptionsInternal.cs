using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetItemReleaseCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ItemId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string ItemId
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "set_ItemId")]
	public void Set(GetItemReleaseCountOptions other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EcomInterface), Member = "GetItemReleaseCount")]
	[Calls(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "set_ItemId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
