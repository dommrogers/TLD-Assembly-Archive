using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionModificationRemoveAttributeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	public string Key
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "set_Key")]
	public void Set(SessionModificationRemoveAttributeOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionModification), Member = "RemoveAttribute")]
	[Calls(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "set_Key")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
