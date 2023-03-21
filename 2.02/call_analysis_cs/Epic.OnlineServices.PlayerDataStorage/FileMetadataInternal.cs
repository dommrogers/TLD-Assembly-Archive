using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct FileMetadataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_FileSizeBytes;

	private IntPtr m_MD5Hash;

	private IntPtr m_Filename;

	public uint FileSizeBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string MD5Hash
	{
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_MD5Hash")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_Filename")]
	public void Set(FileMetadata other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_MD5Hash")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_Filename")]
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
