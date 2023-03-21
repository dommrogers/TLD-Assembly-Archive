using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct AcknowledgeEventIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private ulong m_UiEventId;

	private Result m_Result;

	public ulong UiEventId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Result Result
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Set(AcknowledgeEventIdOptions other)
	{
	}

	[CalledBy(Type = typeof(UIInterface), Member = "AcknowledgeEventId")]
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
