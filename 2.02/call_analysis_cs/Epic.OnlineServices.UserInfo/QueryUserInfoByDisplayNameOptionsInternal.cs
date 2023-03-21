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
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_DisplayName")]
	public void Set(QueryUserInfoByDisplayNameOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "QueryUserInfoByDisplayName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "set_DisplayName")]
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
