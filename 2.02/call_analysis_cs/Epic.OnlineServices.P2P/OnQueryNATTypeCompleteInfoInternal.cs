using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.P2P;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct OnQueryNATTypeCompleteInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

	private NATType m_NATType;

	public Result ResultCode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
	}

	public object ClientData
	{
		[CalledBy(Type = typeof(OnQueryNATTypeCompleteInfo), Member = "Set")]
		[CalledBy(Type = typeof(OnQueryNATTypeCompleteInfo), Member = "Set")]
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

	public NATType NATType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(NATType);
		}
	}
}
