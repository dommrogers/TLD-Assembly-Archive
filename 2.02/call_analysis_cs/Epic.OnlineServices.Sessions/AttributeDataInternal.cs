using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct AttributeDataInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	private AttributeDataValueInternal m_Value;

	public string Key
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		[CalledBy(Type = typeof(AttributeData), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallerCount(Count = 2)]
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

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "set_Value")]
	[CalledBy(Type = typeof(SessionDetailsAttributeInternal), Member = "set_Data")]
	[CalledBy(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "set_SessionAttribute")]
	[CalledBy(Type = typeof(SessionSearchSetParameterOptionsInternal), Member = "set_Parameter")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "Dispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
