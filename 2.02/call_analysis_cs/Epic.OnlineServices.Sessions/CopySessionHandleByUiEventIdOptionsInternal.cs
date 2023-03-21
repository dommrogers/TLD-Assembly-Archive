using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopySessionHandleByUiEventIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private ulong m_UiEventId;

	public ulong UiEventId
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CopySessionHandleByUiEventIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SessionsInterface), Member = "CopySessionHandleByUiEventId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
