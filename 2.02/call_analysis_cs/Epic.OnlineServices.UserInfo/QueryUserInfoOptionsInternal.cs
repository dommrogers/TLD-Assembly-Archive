using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryUserInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(QueryUserInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryUserInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoOptionsInternal), Member = "set_TargetUserId")]
	public void Set(QueryUserInfoOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "QueryUserInfo")]
	[Calls(Type = typeof(QueryUserInfoOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
