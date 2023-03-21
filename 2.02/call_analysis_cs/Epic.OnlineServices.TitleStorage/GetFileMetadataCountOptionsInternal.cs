using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

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
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetFileMetadataCountOptions other)
	{
	}

	[CalledBy(Type = typeof(TitleStorageInterface), Member = "GetFileMetadataCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "set_LocalUserId")]
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
