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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CopySessionHandleByUiEventIdOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "CopySessionHandleByUiEventId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
