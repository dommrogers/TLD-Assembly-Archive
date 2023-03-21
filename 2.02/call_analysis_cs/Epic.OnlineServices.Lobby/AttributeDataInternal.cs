using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct AttributeDataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	private AttributeDataValueInternal m_Value;

	public string Key
	{
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		set
		{
		}
	}

	public AttributeDataValue Value
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Value")]
	public void Set(AttributeData other)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Value")]
	[CalledBy(Type = typeof(AttributeInternal), Member = "set_Data")]
	[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(AttributeDataValueInternal), Member = "Dispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
