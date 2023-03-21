using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct JoinGameAcceptedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_JoinInfo;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private ulong m_UiEventId;

	public object ClientData
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(JoinGameAcceptedCallbackInfo), Member = "Set")]
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

	public string JoinInfo
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(JoinGameAcceptedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(JoinGameAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(JoinGameAcceptedCallbackInfo), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public ulong UiEventId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return default(ulong);
		}
	}
}
