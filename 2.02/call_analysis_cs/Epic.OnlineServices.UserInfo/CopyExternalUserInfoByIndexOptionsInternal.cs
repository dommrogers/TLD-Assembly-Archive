using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyExternalUserInfoByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private uint m_Index;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint Index
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "set_TargetUserId")]
	public void Set(CopyExternalUserInfoByIndexOptions other)
	{
	}

	[Calls(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByIndex")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
