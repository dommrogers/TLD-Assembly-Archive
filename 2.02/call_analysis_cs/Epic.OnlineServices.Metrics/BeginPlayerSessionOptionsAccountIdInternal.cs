using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

[StructLayout(2, Pack = 1, Size = 12)]
internal struct BeginPlayerSessionOptionsAccountIdInternal : ISettable, IDisposable
{
	private MetricsAccountIdType m_AccountIdType;

	private IntPtr m_Epic;

	private IntPtr m_External;

	public EpicAccountId Epic
	{
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string External
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountId), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[Calls(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "set_External")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "set_Epic")]
	public void Set(BeginPlayerSessionOptionsAccountId other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BeginPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BeginPlayerSessionOptionsInternal), Member = "Dispose")]
	public void Dispose()
	{
	}
}
