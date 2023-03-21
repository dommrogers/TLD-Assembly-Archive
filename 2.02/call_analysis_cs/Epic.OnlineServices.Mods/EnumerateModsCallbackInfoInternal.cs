using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct EnumerateModsCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_LocalUserId;

	private IntPtr m_ClientData;

	private ModEnumerationType m_Type;

	public Result ResultCode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Result);
		}
	}

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(EnumerateModsCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(EnumerateModsCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public object ClientData
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(EnumerateModsCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(EnumerateModsCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return default(IntPtr);
		}
	}

	public ModEnumerationType Type
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		get
		{
			return default(ModEnumerationType);
		}
	}
}
