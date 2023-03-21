using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct AddNotifyAuthExpirationOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(AddNotifyAuthExpirationOptions other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ConnectInterface), Member = "AddNotifyAuthExpiration")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
