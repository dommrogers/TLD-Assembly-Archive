using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionModificationSetBucketIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_BucketId;

	public string BucketId
	{
		[CalledBy(Type = typeof(SessionModificationSetBucketIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationSetBucketIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationSetBucketIdOptionsInternal), Member = "set_BucketId")]
	public void Set(SessionModificationSetBucketIdOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionModification), Member = "SetBucketId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionModificationSetBucketIdOptionsInternal), Member = "set_BucketId")]
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
