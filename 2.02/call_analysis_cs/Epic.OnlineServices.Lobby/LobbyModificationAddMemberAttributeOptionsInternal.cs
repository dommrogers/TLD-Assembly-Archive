using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LobbyModificationAddMemberAttributeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Attribute;

	private LobbyAttributeVisibility m_Visibility;

	public AttributeData Attribute
	{
		[CalledBy(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "set_Attribute")]
	public void Set(LobbyModificationAddMemberAttributeOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbyModification), Member = "AddMemberAttribute")]
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
