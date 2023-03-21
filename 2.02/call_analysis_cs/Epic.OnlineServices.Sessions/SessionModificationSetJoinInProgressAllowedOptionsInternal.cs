using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SessionModificationSetJoinInProgressAllowedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_AllowJoinInProgress;

	public bool AllowJoinInProgress
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
	public void Set(SessionModificationSetJoinInProgressAllowedOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
	[CalledBy(Type = typeof(SessionModification), Member = "SetJoinInProgressAllowed")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
