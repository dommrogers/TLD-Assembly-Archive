using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

[StructLayout(2, Pack = 1, Size = 12)]
internal struct EndPlayerSessionOptionsAccountIdInternal : ISettable, IDisposable
{
	private MetricsAccountIdType m_AccountIdType;

	private IntPtr m_Epic;

	private IntPtr m_External;

	public EpicAccountId Epic
	{
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string External
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "set_External")]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "set_Epic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void Set(EndPlayerSessionOptionsAccountId other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Dispose")]
	public void Dispose()
	{
	}
}
