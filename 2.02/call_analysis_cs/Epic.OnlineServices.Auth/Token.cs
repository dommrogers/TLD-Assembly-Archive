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

	public string ClientId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public EpicAccountId AccountId
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public double ExpiresIn
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(double);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string ExpiresAt
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

	public AuthTokenType AuthType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(AuthTokenType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string RefreshToken
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public double RefreshExpiresIn
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(double);
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
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "get_App")]
	[Calls(Type = typeof(TokenInternal), Member = "get_ClientId")]
	[Calls(Type = typeof(TokenInternal), Member = "get_AccountId")]
	[Calls(Type = typeof(TokenInternal), Member = "get_AccessToken")]
	[Calls(Type = typeof(TokenInternal), Member = "get_ExpiresAt")]
	[Calls(Type = typeof(TokenInternal), Member = "get_RefreshToken")]
	[Calls(Type = typeof(TokenInternal), Member = "get_RefreshExpiresAt")]
	[CalledBy(Type = typeof(Token), Member = "Set")]
	[CallsUnknownMethods(Count = 10)]
	internal void Set(TokenInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Token), Member = "Set")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Token()
	{
	}
}
