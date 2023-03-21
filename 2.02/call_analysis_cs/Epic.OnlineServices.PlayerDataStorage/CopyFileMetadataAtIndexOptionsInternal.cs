using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyFileMetadataAtIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_Index;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint Index
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyFileMetadataAtIndexOptions other)
	{
	}

	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "CopyFileMetadataAtIndex")]
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
