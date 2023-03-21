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
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeInternal), Member = "Set")]
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

	[Calls(Type = typeof(AttributeInternal), Member = "set_Data")]
	[CallerCount(Count = 0)]
	public void Set(Attribute other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeInternal), Member = "set_Data")]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
