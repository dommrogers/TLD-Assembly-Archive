using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;

namespace Unity.Cloud.UserReporting;

public class UserReport : UserReportPreview
{
	private class UserReportMetricSorter : IComparer<UserReportMetric>
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "CompareOrdinalHelper")]
		public int Compare(UserReportMetric x, UserReportMetric y)
		{
			return default(int);
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public UserReportMetricSorter()
		{
		}
	}

	private List<UserReportAttachment> _003CAttachments_003Ek__BackingField;

	private List<UserReportMetric> _003CClientMetrics_003Ek__BackingField;

	private List<UserReportNamedValue> _003CDeviceMetadata_003Ek__BackingField;

	private List<UserReportEvent> _003CEvents_003Ek__BackingField;

	private List<UserReportNamedValue> _003CFields_003Ek__BackingField;

	private List<UserReportMeasure> _003CMeasures_003Ek__BackingField;

	private List<UserReportScreenshot> _003CScreenshots_003Ek__BackingField;

	public List<UserReportAttachment> Attachments
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public List<UserReportMetric> ClientMetrics
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public List<UserReportNamedValue> DeviceMetadata
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 5)]
		set
		{
		}
	}

	public List<UserReportEvent> Events
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public List<UserReportNamedValue> Fields
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public List<UserReportMeasure> Measures
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	public List<UserReportScreenshot> Screenshots
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UserReport), Member = "Clone")]
	[CalledBy(Type = typeof(UserReportingClient._003C_003Ec__DisplayClass47_0), Member = "<CreateUserReport>b__1")]
	public UserReport()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UserReport), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UserReport Clone()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UserReportMetric), Member = "Sample")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(UserReportingClient._003C_003Ec__DisplayClass47_0), Member = "<CreateUserReport>b__1")]
	[CallsUnknownMethods(Count = 56)]
	public void Complete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 109)]
	public void Fix()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public string GetDimensionsString()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UserReportScreenshot), Member = "get_Width")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportScreenshot), Member = "get_Height")]
	public void RemoveScreenshots(int maximumWidth, int maximumHeight, int totalBytes, int ignoreCount)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UserReportPreview), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UserReportPreview ToPreview()
	{
		return null;
	}
}
