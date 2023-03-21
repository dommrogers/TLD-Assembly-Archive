using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct StatThresholdsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Name;

	private int m_Threshold;

	public string Name
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(StatThresholds), Member = "Set")]
		[CalledBy(Type = typeof(StatThresholds), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(StatThresholdsInternal), Member = "Set")]
		[CalledBy(Type = typeof(StatThresholdsInternal), Member = "Set")]
		set
		{
		}
	}

	public int Threshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatThresholdsInternal), Member = "set_Name")]
	public void Set(StatThresholds other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatThresholdsInternal), Member = "set_Name")]
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
