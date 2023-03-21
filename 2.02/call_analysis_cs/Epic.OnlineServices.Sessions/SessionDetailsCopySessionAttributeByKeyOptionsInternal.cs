using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionDetailsCopySessionAttributeByKeyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AttrKey;

	public string AttrKey
	{
		[CalledBy(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
	public void Set(SessionDetailsCopySessionAttributeByKeyOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsCopySessionAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByKey")]
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
