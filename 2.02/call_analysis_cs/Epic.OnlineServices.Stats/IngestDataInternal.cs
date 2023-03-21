using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct IngestDataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_StatName;

	private int m_IngestAmount;

	public string StatName
	{
		[CalledBy(Type = typeof(IngestData), Member = "Set")]
		[CalledBy(Type = typeof(IngestData), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(IngestDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(IngestDataInternal), Member = "Set")]
		set
		{
		}
	}

	public int IngestAmount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IngestDataInternal), Member = "set_StatName")]
	public void Set(IngestData other)
	{
	}

	[Calls(Type = typeof(IngestDataInternal), Member = "set_StatName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
