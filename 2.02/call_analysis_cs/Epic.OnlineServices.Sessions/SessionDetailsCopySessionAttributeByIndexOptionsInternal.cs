using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SessionDetailsCopySessionAttributeByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_AttrIndex;

	public uint AttrIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Set(SessionDetailsCopySessionAttributeByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SessionDetails), Member = "CopySessionAttributeByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
