using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetFileMetadataCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetFileMetadataCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "GetFileMetadataCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
