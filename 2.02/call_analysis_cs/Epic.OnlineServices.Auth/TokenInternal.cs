using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 88)]
internal struct TokenInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_App;

	private IntPtr m_ClientId;

	private IntPtr m_AccountId;

	private IntPtr m_AccessToken;

	private double m_ExpiresIn;

	private IntPtr m_ExpiresAt;

	private AuthTokenType m_AuthType;

	private IntPtr m_RefreshToken;

	private double m_RefreshExpiresIn;

	private IntPtr m_RefreshExpiresAt;

	public string App
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ClientId
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId AccountId
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AccessToken
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public double ExpiresIn
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ExpiresAt
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public AuthTokenType AuthType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(AuthTokenType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string RefreshToken
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public double RefreshExpiresIn
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string RefreshExpiresAt
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "set_App")]
	[Calls(Type = typeof(TokenInternal), Member = "set_ClientId")]
	[Calls(Type = typeof(TokenInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(TokenInternal), Member = "set_AccessToken")]
	[Calls(Type = typeof(TokenInternal), Member = "set_ExpiresAt")]
	[Calls(Type = typeof(TokenInternal), Member = "set_RefreshToken")]
	[Calls(Type = typeof(TokenInternal), Member = "set_RefreshExpiresAt")]
	public void Set(Token other)
	{
	}

	[CalledBy(Type = typeof(VerifyUserAuthOptionsInternal), Member = "set_AuthToken")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
