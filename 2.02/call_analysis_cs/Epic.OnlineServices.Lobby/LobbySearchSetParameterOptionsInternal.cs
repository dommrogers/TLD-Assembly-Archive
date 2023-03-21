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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ComparisonOp ComparisonOp
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
	public void Set(LobbySearchSetParameterOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
	[CalledBy(Type = typeof(LobbySearch), Member = "SetParameter")]
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
