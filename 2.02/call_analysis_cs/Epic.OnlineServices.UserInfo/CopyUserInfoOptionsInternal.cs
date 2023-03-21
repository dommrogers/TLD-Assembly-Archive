using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyUserInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyUserInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUserInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(CopyUserInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUserInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUserInfoOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyUserInfoOptionsInternal), Member = "set_TargetUserId")]
	public void Set(CopyUserInfoOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyUserInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyUserInfoOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyUserInfoOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
