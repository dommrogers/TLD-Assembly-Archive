using System;
using Cpp2ILInjected.CallAnalysis;

namespace Users;

public struct PlatformProfile
{
	private IntPtr _OnlineHash;

	private IntPtr _ApplicationDisplayName;

	private IntPtr _GameDisplayName;

	private IntPtr _Privileges;

	private int PrivilegesSize;

	public int AgeGroup;

	public uint GamerScore;

	public int Reputation;

	public int SponsorId;

	private ProfileFlags Flags;

	public bool IsGuest
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsSignedIn
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public string OnlineHash
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string ApplicationDisplayName
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string GameDisplayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool HasSponsor
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsSignedInLiveUser
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool IsSponsoredGuest
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int[] Privileges
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}
}
