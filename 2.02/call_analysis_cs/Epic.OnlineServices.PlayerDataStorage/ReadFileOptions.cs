using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
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
			return default(uint);
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
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public OnFileTransferProgressCallback FileTransferProgressCallback
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ReadFileOptions()
	{
	}
}
