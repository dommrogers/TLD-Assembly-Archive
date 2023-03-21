using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public class FileMetadata : ISettable
{
	private uint _003CFileSizeBytes_003Ek__BackingField;

	private string _003CMD5Hash_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	public uint FileSizeBytes
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_MD5Hash")]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_Filename")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(FileMetadataInternal? other)
	{
	}

	[Calls(Type = typeof(FileMetadataInternal), Member = "get_Filename")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(FileMetadataInternal), Member = "get_MD5Hash")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public FileMetadata()
	{
	}
}
