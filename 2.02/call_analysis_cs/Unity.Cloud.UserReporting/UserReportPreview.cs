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
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public long ContentLength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public DateTime ExpiresOn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return default(DateTime);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string GeoCountry
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
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
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string IPAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
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
			return default(bool);
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
			return default(bool);
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
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(LicenseLevel);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string ProjectIdentifier
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	public DateTime ReceivedOn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
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
		[CallerCount(Count = 4)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserReport), Member = "ToPreview")]
	[CallsUnknownMethods(Count = 12)]
	public UserReportPreview()
	{
	}
}
