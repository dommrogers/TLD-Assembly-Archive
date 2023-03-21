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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(IngestDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(IngestDataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IngestDataInternal), Member = "set_StatName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
