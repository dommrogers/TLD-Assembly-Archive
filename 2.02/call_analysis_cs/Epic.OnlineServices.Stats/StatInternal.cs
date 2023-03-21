using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct StatInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Name;

	private long m_StartTime;

	private long m_EndTime;

	private int m_Value;

	public string Name
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Stat), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(StatInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(StatInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(StatInternal), Member = "Set")]
		set
		{
		}
	}

	public int Value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(StatInternal), Member = "Set")]
	[Calls(Type = typeof(StatInternal), Member = "set_EndTime")]
	[Calls(Type = typeof(StatInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(StatInternal), Member = "set_Name")]
	[CallerCount(Count = 1)]
	public void Set(Stat other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatInternal), Member = "Set")]
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
