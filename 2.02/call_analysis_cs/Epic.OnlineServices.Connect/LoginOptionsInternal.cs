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
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(CredentialsInternal), Member = "Set")]
		set
		{
		}
	}

	public UserLoginInfo UserLoginInfo
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UserLoginInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LoginOptionsInternal), Member = "Set")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "set_UserLoginInfo")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "Login")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
