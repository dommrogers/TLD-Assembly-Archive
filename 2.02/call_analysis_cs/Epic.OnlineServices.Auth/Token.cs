using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class Token : ISettable
{
	private string _003CApp_003Ek__BackingField;

	private string _003CClientId_003Ek__BackingField;

	private EpicAccountId _003CAccountId_003Ek__BackingField;

	private string _003CAccessToken_003Ek__BackingField;

	private double _003CExpiresIn_003Ek__BackingField;

	private string _003CExpiresAt_003Ek__BackingField;

	private AuthTokenType _003CAuthType_003Ek__BackingField;

	private string _003CRefreshToken_003Ek__BackingField;

	private double _003CRefreshExpiresIn_003Ek__BackingField;

	private string _003CRefreshExpiresAt_003Ek__BackingField;

	public string App
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

	public string ClientId
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

	public EpicAccountId AccountId
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

	public string AccessToken
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

	public double ExpiresIn
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ExpiresAt
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

	public AuthTokenType AuthType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(AuthTokenType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string RefreshToken
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

	public double RefreshExpiresIn
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string RefreshExpiresAt
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

	[CalledBy(Type = typeof(Token), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "get_App")]
	[Calls(Type = typeof(TokenInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(TokenInternal), Member = "get_AccountId")]
	[Calls(Type = typeof(TokenInternal), Member = "get_AccessToken")]
	[Calls(Type = typeof(TokenInternal), Member = "get_ExpiresAt")]
	[Calls(Type = typeof(TokenInternal), Member = "get_RefreshToken")]
	[Calls(Type = typeof(TokenInternal), Member = "get_RefreshExpiresAt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void Set(TokenInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Token), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Token()
	{
	}
}
