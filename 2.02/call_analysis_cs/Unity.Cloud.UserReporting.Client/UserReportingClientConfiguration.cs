using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Client;

public class UserReportingClientConfiguration
{
	private int _003CFramesPerMeasure_003Ek__BackingField;

	private int _003CMaximumEventCount_003Ek__BackingField;

	private int _003CMaximumMeasureCount_003Ek__BackingField;

	private int _003CMaximumScreenshotCount_003Ek__BackingField;

	private MetricsGatheringMode _003CMetricsGatheringMode_003Ek__BackingField;

	public int FramesPerMeasure
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set
		{
		}
	}

	public int MaximumEventCount
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	public int MaximumMeasureCount
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set
		{
		}
	}

	public int MaximumScreenshotCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public MetricsGatheringMode MetricsGatheringMode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		get
		{
			return default(MetricsGatheringMode);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal set
		{
		}
	}

	[CallerCount(Count = 0)]
	public UserReportingClientConfiguration()
	{
	}

	[CallerCount(Count = 0)]
	public UserReportingClientConfiguration(int maximumEventCount, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
	{
	}

	[CallerCount(Count = 0)]
	public UserReportingClientConfiguration(int maximumEventCount, MetricsGatheringMode metricsGatheringMode, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
	{
	}
}
