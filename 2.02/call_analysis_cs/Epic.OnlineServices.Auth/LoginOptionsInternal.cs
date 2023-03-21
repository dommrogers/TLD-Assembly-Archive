using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LoginOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Credentials;

	private AuthScopeFlags m_ScopeFlags;

	public Credentials Credentials
	{
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(CredentialsInternal), Member = "Set")]
		set
		{
		}
	}

	public AuthScopeFlags ScopeFlags
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	public void Set(LoginOptions other)
	{
	}

	[CalledBy(Type = typeof(AuthInterface), Member = "Login")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
