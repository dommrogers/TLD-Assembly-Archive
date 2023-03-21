using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

[StructLayout(2, Pack = 1, Size = 12)]
internal struct EndPlayerSessionOptionsAccountIdInternal : ISettable, IDisposable
{
	[FieldOffset(0)]
	private MetricsAccountIdType m_AccountIdType;

	[FieldOffset(4)]
	private IntPtr m_Epic;

	[FieldOffset(4)]
	private IntPtr m_External;

	public EpicAccountId Epic
	{
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string External
	{
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountId), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "set_Epic")]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "set_External")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Set(EndPlayerSessionOptionsAccountId other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EndPlayerSessionOptionsAccountIdInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CalledBy(Type = typeof(EndPlayerSessionOptionsInternal), Member = "Dispose")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
