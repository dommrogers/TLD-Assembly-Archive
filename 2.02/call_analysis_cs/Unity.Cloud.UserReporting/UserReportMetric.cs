using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;

namespace Unity.Cloud.UserReporting;

public struct UserReportMetric
{
	private int _003CCount_003Ek__BackingField;

	private double _003CMaximum_003Ek__BackingField;

	private double _003CMinimum_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private double _003CSum_003Ek__BackingField;

	public double Average
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
	}

	public int Count
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public double Maximum
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public double Minimum
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public double Sum
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UserReport), Member = "Complete")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Math), Member = "Min")]
	[Calls(Type = typeof(Math), Member = "Max")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Sample(double value)
	{
	}
}
