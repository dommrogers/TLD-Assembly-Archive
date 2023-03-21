using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct AttributeInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Data;

	private LobbyAttributeVisibility m_Visibility;

	public AttributeData Data
	{
		[CalledBy(Type = typeof(Attribute), Member = "Set")]
		[CalledBy(Type = typeof(Attribute), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public LobbyAttributeVisibility Visibility
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(LobbyAttributeVisibility);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeInternal), Member = "set_Data")]
	public void Set(Attribute other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeInternal), Member = "set_Data")]
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
