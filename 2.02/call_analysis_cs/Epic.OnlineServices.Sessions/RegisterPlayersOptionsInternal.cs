using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct RegisterPlayersOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_PlayersToRegister;

	private uint m_PlayersToRegisterCount;

	public string SessionName
	{
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId[] PlayersToRegister
	{
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_PlayersToRegister")]
	public void Set(RegisterPlayersOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "RegisterPlayers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_PlayersToRegister")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
