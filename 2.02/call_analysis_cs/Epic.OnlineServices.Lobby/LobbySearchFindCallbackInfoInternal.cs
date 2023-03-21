using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbySearchFindCallbackInfoInternal : ICallbackInfoInternal
{
	private Result m_ResultCode;

	private IntPtr m_ClientData;

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
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(LobbySearchFindCallbackInfo), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchFindCallbackInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
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
}
