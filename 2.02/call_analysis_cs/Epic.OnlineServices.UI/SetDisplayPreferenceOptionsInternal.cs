using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SetDisplayPreferenceOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private NotificationLocation m_NotificationLocation;

	public NotificationLocation NotificationLocation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(SetDisplayPreferenceOptions other)
	{
	}

	[CalledBy(Type = typeof(UIInterface), Member = "SetDisplayPreference")]
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
