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
		[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
	public void Set(SessionModificationSetJoinInProgressAllowedOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionModification), Member = "SetJoinInProgressAllowed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionModificationSetJoinInProgressAllowedOptionsInternal), Member = "set_AllowJoinInProgress")]
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
