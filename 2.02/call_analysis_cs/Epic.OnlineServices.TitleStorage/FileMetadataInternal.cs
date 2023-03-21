using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct FileMetadataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_FileSizeBytes;

	private IntPtr m_MD5Hash;

	private IntPtr m_Filename;

	public uint FileSizeBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string MD5Hash
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadata), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		[CalledBy(Type = typeof(FileMetadataInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(FileMetadataInternal), Member = "set_Filename")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_MD5Hash")]
	public void Set(FileMetadata other)
	{
	}

	[Calls(Type = typeof(FileMetadataInternal), Member = "set_Filename")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "set_MD5Hash")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
