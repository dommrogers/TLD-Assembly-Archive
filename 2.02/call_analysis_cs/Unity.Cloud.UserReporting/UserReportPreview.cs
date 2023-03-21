using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.Authorization;

namespace Unity.Cloud.UserReporting;

public class UserReportPreview
{
	private List<UserReportMetric> _003CAggregateMetrics_003Ek__BackingField;

	private UserReportAppearanceHint _003CAppearanceHint_003Ek__BackingField;

	private long _003CContentLength_003Ek__BackingField;

	private List<UserReportNamedValue> _003CDimensions_003Ek__BackingField;

	private DateTime _003CExpiresOn_003Ek__BackingField;

	private string _003CGeoCountry_003Ek__BackingField;

	private string _003CIdentifier_003Ek__BackingField;

	private string _003CIPAddress_003Ek__BackingField;

	private bool _003CIsHiddenWithoutDimension_003Ek__BackingField;

	private bool _003CIsSilent_003Ek__BackingField;

	private bool _003CIsTemporary_003Ek__BackingField;

	private LicenseLevel _003CLicenseLevel_003Ek__BackingField;

	private string _003CProjectIdentifier_003Ek__BackingField;

	private DateTime _003CReceivedOn_003Ek__BackingField;

	private string _003CSummary_003Ek__BackingField;

	private UserReportScreenshot _003CThumbnail_003Ek__BackingField;

	public List<UserReportMetric> AggregateMetrics
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public UserReportAppearanceHint AppearanceHint
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(UserReportAppearanceHint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long ContentLength
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public List<UserReportNamedValue> Dimensions
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public DateTime ExpiresOn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string GeoCountry
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string Identifier
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
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string IPAddress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public bool IsHiddenWithoutDimension
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool IsSilent
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool IsTemporary
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public LicenseLevel LicenseLevel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(LicenseLevel);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ProjectIdentifier
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		set
		{
		}
	}

	public DateTime ReceivedOn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string Summary
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public UserReportScreenshot Thumbnail
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(UserReportScreenshot);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UserReport), Member = "ToPreview")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public UserReportPreview()
	{
	}
}
