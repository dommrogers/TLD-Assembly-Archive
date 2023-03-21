using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct EndPlayerSessionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private EndPlayerSessionOptionsAccountIdInternal m_AccountId;

	public EndPlayerSessionOptionsAccountId AccountId
	{
		[CalledBy(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPlayerSessionOptionsInternal), Member = "set_AccountId")]
	public void Set(EndPlayerSessionOptions other)
	{
	}

	[CalledBy(Type = typeof(MetricsInterface), Member = "EndPlayerSession")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EndPlayerSessionOptionsInternal), Member = "set_AccountId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
