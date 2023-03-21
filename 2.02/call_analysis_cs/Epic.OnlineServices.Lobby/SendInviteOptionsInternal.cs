using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct SendInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public string LobbyId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	public void Set(SendInviteOptions other)
	{
	}

	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "SendInvite")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LobbyId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
