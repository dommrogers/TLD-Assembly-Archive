using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SessionModificationSetPermissionLevelOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private OnlineSessionPermissionLevel m_PermissionLevel;

	public OnlineSessionPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Set(SessionModificationSetPermissionLevelOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionModification), Member = "SetPermissionLevel")]
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
