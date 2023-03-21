using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetFriendsVisibleOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetFriendsVisibleOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetFriendsVisibleOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFriendsVisibleOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetFriendsVisibleOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetFriendsVisibleOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(UIInterface), Member = "GetFriendsVisible")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
