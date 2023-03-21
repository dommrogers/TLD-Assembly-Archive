using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyProductUserInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyProductUserInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyProductUserInfoOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyProductUserInfoOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyProductUserInfoOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyProductUserInfoOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserInfo")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
