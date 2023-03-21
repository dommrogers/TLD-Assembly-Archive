using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SetToggleFriendsKeyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private KeyCombination m_KeyCombination;

	public KeyCombination KeyCombination
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(SetToggleFriendsKeyOptions other)
	{
	}

	[CalledBy(Type = typeof(UIInterface), Member = "SetToggleFriendsKey")]
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
