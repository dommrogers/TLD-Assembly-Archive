using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct UnregisterPlayersOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_PlayersToUnregister;

	private uint m_PlayersToUnregisterCount;

	public string SessionName
	{
		[CalledBy(Type = typeof(UnregisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnregisterPlayersOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ProductUserId[] PlayersToUnregister
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UnregisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnregisterPlayersOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnregisterPlayersOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(UnregisterPlayersOptionsInternal), Member = "set_PlayersToUnregister")]
	public void Set(UnregisterPlayersOptions other)
	{
	}

	[Calls(Type = typeof(UnregisterPlayersOptionsInternal), Member = "set_PlayersToUnregister")]
	[Calls(Type = typeof(UnregisterPlayersOptionsInternal), Member = "set_SessionName")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "UnregisterPlayers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
