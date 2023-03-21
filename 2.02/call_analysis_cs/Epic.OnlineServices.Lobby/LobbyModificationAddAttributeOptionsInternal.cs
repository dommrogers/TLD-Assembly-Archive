using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbyModificationAddAttributeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Attribute;

	private LobbyAttributeVisibility m_Visibility;

	public AttributeData Attribute
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public LobbyAttributeVisibility Visibility
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
	[CallerCount(Count = 0)]
	public void Set(LobbyModificationAddAttributeOptions other)
	{
	}

	[Calls(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbyModification), Member = "AddAttribute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
