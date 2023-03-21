using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(AddNotifyLoginStatusChangedOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AuthInterface), Member = "AddNotifyLoginStatusChanged")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
