using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyFileMetadataAtIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataAtIndex")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
