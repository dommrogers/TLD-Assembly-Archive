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
		[CallerCount(Count = 52)]
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

	public string Country
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public string DisplayName
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
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public string PreferredLanguage
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string Nickname
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_UserId")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_Country")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_PreferredLanguage")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "get_Nickname")]
	[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(UserInfoDataInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserInfoData), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UserInfoData()
	{
	}
}
