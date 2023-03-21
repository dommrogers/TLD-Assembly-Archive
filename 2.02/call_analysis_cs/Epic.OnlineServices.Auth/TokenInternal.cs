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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Token), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		set
		{
		}
	}

	public string ClientId
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public EpicAccountId AccountId
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		set
		{
		}
	}

	public string AccessToken
	{
		[CalledBy(Type = typeof(Token), Member = "Set")]
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
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
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
			return default(double);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ExpiresAt
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Token), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		[CallerCount(Count = 1)]
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
			return default(double);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string RefreshExpiresAt
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Token), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(TokenInternal), Member = "set_RefreshToken")]
	[Calls(Type = typeof(TokenInternal), Member = "set_RefreshExpiresAt")]
	[CalledBy(Type = typeof(TokenInternal), Member = "Set")]
	[Calls(Type = typeof(TokenInternal), Member = "set_ExpiresAt")]
	[Calls(Type = typeof(TokenInternal), Member = "set_App")]
	[Calls(Type = typeof(TokenInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(TokenInternal), Member = "set_ClientId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "set_AccessToken")]
	public void Set(Token other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TokenInternal), Member = "Set")]
	[CalledBy(Type = typeof(VerifyUserAuthOptionsInternal), Member = "set_AuthToken")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
