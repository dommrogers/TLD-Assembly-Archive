using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyProductUserExternalAccountByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private uint m_ExternalAccountInfoIndex;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint ExternalAccountInfoIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByIndexOptionsInternal), Member = "set_TargetUserId")]
	public void Set(CopyProductUserExternalAccountByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByIndexOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByIndex")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
