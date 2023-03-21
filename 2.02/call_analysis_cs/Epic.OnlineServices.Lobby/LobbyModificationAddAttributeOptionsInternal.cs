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
		[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "Set")]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
	public void Set(LobbyModificationAddAttributeOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyModification), Member = "AddAttribute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
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
