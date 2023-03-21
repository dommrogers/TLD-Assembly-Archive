using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct QueryFileListOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
	public void Set(QueryFileListOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "QueryFileList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
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
