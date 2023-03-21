using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbySearchSetParameterOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Parameter;

	private ComparisonOp m_ComparisonOp;

	public AttributeData Parameter
	{
		[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
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
	[Calls(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
	public void Set(LobbySearchSetParameterOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbySearch), Member = "SetParameter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
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
