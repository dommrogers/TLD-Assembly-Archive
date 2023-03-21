using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LoginOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Credentials;

	private IntPtr m_UserLoginInfo;

	public Credentials Credentials
	{
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CredentialsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public UserLoginInfo UserLoginInfo
	{
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UserLoginInfoInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_UserLoginInfo")]
	public void Set(LoginOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "Login")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_UserLoginInfo")]
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
