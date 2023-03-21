using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public class UserReport : UserReportPreview
{
	private class UserReportMetricSorter : IComparer<UserReportMetric>
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareOrdinalHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		public int Compare(UserReportMetric x, UserReportMetric y)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	public List<UserReportNamedValue> DeviceMetadata
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

	public List<UserReportEvent> Events
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	public List<UserReportNamedValue> Fields
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
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
		[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(UserReport), Member = "Clone")]
	[CalledBy(TypeFullName = "Unity.Cloud.UserReporting.Client.UserReportingClient.<>c__DisplayClass47_0", Member = "<CreateUserReport>b__1")]
	[CallerCount(Count = 2)]
	public UserReport()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReport), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public UserReport Clone()
	{
		return null;
	}

	[CalledBy(TypeFullName = "Unity.Cloud.UserReporting.Client.UserReportingClient.<>c__DisplayClass47_0", Member = "<CreateUserReport>b__1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserReportMetric), Member = "Sample")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 9)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public string GetDimensionsString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportScreenshot), Member = "get_Width")]
	[Calls(Type = typeof(UserReportScreenshot), Member = "get_Height")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveScreenshots(int maximumWidth, int maximumHeight, int totalBytes, int ignoreCount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportPreview), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public UserReportPreview ToPreview()
	{
		return null;
	}
}
