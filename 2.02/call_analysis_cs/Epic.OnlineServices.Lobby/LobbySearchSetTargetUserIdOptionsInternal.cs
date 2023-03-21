using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbySearchSetTargetUserIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbySearchSetTargetUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchSetTargetUserIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchSetTargetUserIdOptionsInternal), Member = "set_TargetUserId")]
	public void Set(LobbySearchSetTargetUserIdOptions other)
	{
	}

	[Calls(Type = typeof(LobbySearchSetTargetUserIdOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LobbySearch), Member = "SetTargetUserId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
