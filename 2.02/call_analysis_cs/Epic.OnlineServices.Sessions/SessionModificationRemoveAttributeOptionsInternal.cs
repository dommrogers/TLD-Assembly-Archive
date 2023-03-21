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
		[CalledBy(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionModificationRemoveAttributeOptionsInternal), Member = "set_Key")]
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
