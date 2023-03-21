using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyFileMetadataByFilenameOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_Filename")]
	public void Set(CopyFileMetadataByFilenameOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "CopyFileMetadataByFilename")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_Filename")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
