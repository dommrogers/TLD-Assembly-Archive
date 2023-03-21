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
			return default(double);
		}
	}

	public int Count
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(double);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public double Minimum
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(double);
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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
			return default(double);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min")]
	[Calls(Type = typeof(Math), Member = "Max")]
	[CalledBy(Type = typeof(UserReport), Member = "Complete")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SampleClientMetric")]
	[CalledBy(Type = typeof(UserReportingClient), Member = "SampleMetric")]
	public void Sample(double value)
	{
	}
}
