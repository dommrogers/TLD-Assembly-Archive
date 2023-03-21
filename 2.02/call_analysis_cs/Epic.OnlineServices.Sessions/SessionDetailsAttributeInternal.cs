using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SessionDetailsAttributeInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Data;

	private SessionAttributeAdvertisementType m_AdvertisementType;

	public AttributeData Data
	{
		[CalledBy(Type = typeof(SessionDetailsAttribute), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsAttribute), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsAttributeInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsAttributeInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	public SessionAttributeAdvertisementType AdvertisementType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(SessionAttributeAdvertisementType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "set_Data")]
	public void Set(SessionDetailsAttribute other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "set_Data")]
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
