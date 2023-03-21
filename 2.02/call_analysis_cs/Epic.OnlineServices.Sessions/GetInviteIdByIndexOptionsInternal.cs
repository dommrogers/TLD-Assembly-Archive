using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetInviteIdByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_Index;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "Set")]
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

	[Calls(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(GetInviteIdByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "GetInviteIdByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
