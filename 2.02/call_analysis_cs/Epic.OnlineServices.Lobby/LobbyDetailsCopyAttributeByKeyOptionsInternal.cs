using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbyDetailsCopyAttributeByKeyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AttrKey;

	public string AttrKey
	{
		[CalledBy(Type = typeof(LobbyDetailsCopyAttributeByKeyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyDetailsCopyAttributeByKeyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyDetailsCopyAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
	public void Set(LobbyDetailsCopyAttributeByKeyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyAttributeByKey")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyDetailsCopyAttributeByKeyOptionsInternal), Member = "set_AttrKey")]
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
