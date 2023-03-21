using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbySearchRemoveParameterOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	private ComparisonOp m_ComparisonOp;

	public string Key
	{
		[CalledBy(Type = typeof(LobbySearchRemoveParameterOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchRemoveParameterOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ComparisonOp ComparisonOp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchRemoveParameterOptionsInternal), Member = "set_Key")]
	public void Set(LobbySearchRemoveParameterOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbySearch), Member = "RemoveParameter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbySearchRemoveParameterOptionsInternal), Member = "set_Key")]
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
