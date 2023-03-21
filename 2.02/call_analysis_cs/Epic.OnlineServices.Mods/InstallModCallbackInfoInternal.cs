using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct InstallModCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_LocalUserId;

	private IntPtr m_ClientData;

	private IntPtr m_Mod;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
	}

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(InstallModCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public object ClientData
	{
		[CalledBy(Type = typeof(InstallModCallbackInfo), Member = "Set")]
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
		[CallerCount(Count = 52)]
		get
		{
			return default(IntPtr);
		}
	}

	public ModIdentifier Mod
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(InstallModCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}
}
