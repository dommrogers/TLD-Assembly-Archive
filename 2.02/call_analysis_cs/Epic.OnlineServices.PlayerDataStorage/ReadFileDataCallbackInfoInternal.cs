using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	private uint m_TotalFileSizeBytes;

	private int m_IsLastChunk;

	private uint m_DataChunkLengthBytes;

	private IntPtr m_DataChunk;

	public object ClientData
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public string Filename
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public uint TotalFileSizeBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(uint);
		}
	}

	public bool IsLastChunk
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
		get
		{
			return default(bool);
		}
	}

	public byte[] DataChunk
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ReadFileDataCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}
}
