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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public AttributeDataValue Value
	{
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
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

	[CalledBy(Type = typeof(AttributeInternal), Member = "set_Data")]
	[CalledBy(Type = typeof(LobbyModificationAddAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbyModificationAddMemberAttributeOptionsInternal), Member = "set_Attribute")]
	[CalledBy(Type = typeof(LobbySearchSetParameterOptionsInternal), Member = "set_Parameter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Value")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
