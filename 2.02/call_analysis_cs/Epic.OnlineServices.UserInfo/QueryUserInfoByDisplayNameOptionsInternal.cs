using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryUserInfoByDisplayNameOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_DisplayName;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_DisplayName")]
	[CallerCount(Count = 0)]
	public void Set(QueryUserInfoByDisplayNameOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "QueryUserInfoByDisplayName")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_DisplayName")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
