using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct WriteFileDataCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	private uint m_DataBufferLengthBytes;

	public object ClientData
	{
		[CalledBy(Type = typeof(WriteFileDataCallbackInfo), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(IntPtr);
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(WriteFileDataCallbackInfo), Member = "Set")]
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
		[CalledBy(Type = typeof(WriteFileDataCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public uint DataBufferLengthBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(uint);
		}
	}
}
