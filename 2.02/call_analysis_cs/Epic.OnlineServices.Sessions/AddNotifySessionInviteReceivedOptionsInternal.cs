using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct AddNotifySessionInviteReceivedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Set(AddNotifySessionInviteReceivedOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SessionsInterface), Member = "AddNotifySessionInviteReceived")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
