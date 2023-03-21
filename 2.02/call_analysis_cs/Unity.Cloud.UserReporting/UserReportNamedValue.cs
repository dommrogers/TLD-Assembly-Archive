using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public struct UserReportNamedValue
{
	private string _003CName_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string Value
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 67)]
	public UserReportNamedValue(string name, string value)
	{
	}
}
