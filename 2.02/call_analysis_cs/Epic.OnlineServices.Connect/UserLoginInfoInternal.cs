using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct UserLoginInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_DisplayName;

	public string DisplayName
	{
		[CalledBy(Type = typeof(UserLoginInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(UserLoginInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UserLoginInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(UserLoginInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserLoginInfoInternal), Member = "set_DisplayName")]
	public void Set(UserLoginInfo other)
	{
	}

	[CalledBy(Type = typeof(LoginOptionsInternal), Member = "set_UserLoginInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserLoginInfoInternal), Member = "set_DisplayName")]
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
