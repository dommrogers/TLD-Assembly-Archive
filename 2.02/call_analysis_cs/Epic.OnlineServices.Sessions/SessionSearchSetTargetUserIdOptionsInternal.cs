using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionSearchSetTargetUserIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "set_TargetUserId")]
	public void Set(SessionSearchSetTargetUserIdOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionSearch), Member = "SetTargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionSearchSetTargetUserIdOptionsInternal), Member = "set_TargetUserId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
