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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SessionDetailsAttribute), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsAttribute), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsAttributeInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsAttributeInternal), Member = "Set")]
		set
		{
		}
	}

	public SessionAttributeAdvertisementType AdvertisementType
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "set_Data")]
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
