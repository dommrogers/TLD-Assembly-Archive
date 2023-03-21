using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct JoinSessionAcceptedCallbackInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private ulong m_UiEventId;

	public object ClientData
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		get
		{
			return null;
		}
	}

	public ulong UiEventId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return default(ulong);
		}
	}
}
