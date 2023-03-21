using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

public class FileMetadata : ISettable
{
	private uint _003CFileSizeBytes_003Ek__BackingField;

	private string _003CMD5Hash_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	public uint FileSizeBytes
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string MD5Hash
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string Filename
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_MD5Hash")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_Filename")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(FileMetadataInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_MD5Hash")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_Filename")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FileMetadata()
	{
	}
}
