using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyFileMetadataByFilenameOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
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

	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataByFilename")]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_Filename")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
