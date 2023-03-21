using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct ActiveSessionGetRegisteredPlayerByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_PlayerIndex;

	public uint PlayerIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(ActiveSessionGetRegisteredPlayerByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ActiveSession), Member = "GetRegisteredPlayerByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
