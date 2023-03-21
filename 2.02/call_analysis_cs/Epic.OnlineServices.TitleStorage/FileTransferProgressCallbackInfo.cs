using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public class FileTransferProgressCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	private uint _003CBytesTransferred_003Ek__BackingField;

	private uint _003CTotalFileSizeBytes_003Ek__BackingField;

	public object ClientData
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
		private set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	public string Filename
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		private set
		{
		}
	}

	public uint BytesTransferred
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public uint TotalFileSizeBytes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FileTransferProgressCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(FileTransferProgressCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(FileTransferProgressCallbackInfoInternal), Member = "get_Filename")]
	[CalledBy(Type = typeof(FileTransferProgressCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(FileTransferProgressCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FileTransferProgressCallbackInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FileTransferProgressCallbackInfo()
	{
	}
}
