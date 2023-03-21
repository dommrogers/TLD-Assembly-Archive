using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public class ReadFileDataCallbackInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private string _003CFilename_003Ek__BackingField;

	private uint _003CTotalFileSizeBytes_003Ek__BackingField;

	private bool _003CIsLastChunk_003Ek__BackingField;

	private byte[] _003CDataChunk_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public ProductUserId LocalUserId
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
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public bool IsLastChunk
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public byte[] DataChunk
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		[CompilerGenerated]
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
	[Calls(Type = typeof(ReadFileDataCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(ReadFileDataCallbackInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(ReadFileDataCallbackInfoInternal), Member = "get_Filename")]
	[Calls(Type = typeof(ReadFileDataCallbackInfoInternal), Member = "get_IsLastChunk")]
	[Calls(Type = typeof(ReadFileDataCallbackInfoInternal), Member = "get_DataChunk")]
	[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 6)]
	internal void Set(ReadFileDataCallbackInfoInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ReadFileDataCallbackInfo()
	{
	}
}
