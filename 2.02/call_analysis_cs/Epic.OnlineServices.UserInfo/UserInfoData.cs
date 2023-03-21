using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public class UserInfoData : ISettable
{
	private EpicAccountId _003CUserId_003Ek__BackingField;

	private string _003CCountry_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private string _003CPreferredLanguage_003Ek__BackingField;

	private string _003CNickname_003Ek__BackingField;

	public EpicAccountId UserId
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

	public string Country
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

	public string DisplayName
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
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public string PreferredLanguage
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

	public string Nickname
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_UserId")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_Country")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_PreferredLanguage")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_Nickname")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(UserInfoDataInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserInfoData), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public UserInfoData()
	{
	}
}
