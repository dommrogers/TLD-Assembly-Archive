using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public class ReadFileOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	private uint _003CReadChunkLengthBytes_003Ek__BackingField;

	private OnReadFileDataCallback _003CReadFileDataCallback_003Ek__BackingField;

	private OnFileTransferProgressCallback _003CFileTransferProgressCallback_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string Filename
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

	public uint ReadChunkLengthBytes
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	public OnReadFileDataCallback ReadFileDataCallback
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public OnFileTransferProgressCallback FileTransferProgressCallback
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ReadFileOptions()
	{
	}
}
