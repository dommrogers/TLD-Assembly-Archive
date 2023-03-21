using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct UserInfoDataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private IntPtr m_Country;

	private IntPtr m_DisplayName;

	private IntPtr m_PreferredLanguage;

	private IntPtr m_Nickname;

	public EpicAccountId UserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
		set
		{
		}
	}

	public string Country
	{
		[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
		set
		{
		}
	}

	public string DisplayName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
		set
		{
		}
	}

	public string PreferredLanguage
	{
		[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
		set
		{
		}
	}

	public string Nickname
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(UserInfoData), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "set_UserId")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "set_Country")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "set_PreferredLanguage")]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "set_Nickname")]
	[CalledBy(Type = typeof(UserInfoDataInternal), Member = "Set")]
	public void Set(UserInfoData other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserInfoDataInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
