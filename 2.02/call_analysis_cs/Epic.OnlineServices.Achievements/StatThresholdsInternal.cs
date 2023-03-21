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
		[CalledBy(Type = typeof(StatThresholds), Member = "Set")]
		[CalledBy(Type = typeof(StatThresholds), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(StatThresholdsInternal), Member = "Set")]
		[CalledBy(Type = typeof(StatThresholdsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(StatThresholdsInternal), Member = "set_Name")]
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
