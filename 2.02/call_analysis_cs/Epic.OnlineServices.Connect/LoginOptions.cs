using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class LoginOptions
{
	private Credentials _003CCredentials_003Ek__BackingField;

	private UserLoginInfo _003CUserLoginInfo_003Ek__BackingField;

	public Credentials Credentials
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public UserLoginInfo UserLoginInfo
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LoginOptions()
	{
	}
}
