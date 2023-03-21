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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId[] PlayersToRegister
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
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
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_PlayersToRegister")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "set_SessionName")]
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
