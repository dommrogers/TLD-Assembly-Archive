using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetExternalUserInfoCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "set_TargetUserId")]
	public void Set(GetExternalUserInfoCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "GetExternalUserInfoCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
