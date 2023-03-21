using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SessionSearchCopySearchResultByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_SessionIndex;

	public uint SessionIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(SessionSearchCopySearchResultByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionSearch), Member = "CopySearchResultByIndex")]
	[CallerCount(Count = 1)]
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
