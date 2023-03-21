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
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
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
			return (IntPtr)0;
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionAcceptedCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public ulong UiEventId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return 0uL;
		}
	}
}
