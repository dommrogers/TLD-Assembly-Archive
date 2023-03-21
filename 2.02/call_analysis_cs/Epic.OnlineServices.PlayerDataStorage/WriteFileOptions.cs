using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

public class WriteFileOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	private uint _003CChunkLengthBytes_003Ek__BackingField;

	private OnWriteFileDataCallback _003CWriteFileDataCallback_003Ek__BackingField;

	private OnFileTransferProgressCallback _003CFileTransferProgressCallback_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public uint ChunkLengthBytes
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public OnWriteFileDataCallback WriteFileDataCallback
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public OnFileTransferProgressCallback FileTransferProgressCallback
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public WriteFileOptions()
	{
	}
}
