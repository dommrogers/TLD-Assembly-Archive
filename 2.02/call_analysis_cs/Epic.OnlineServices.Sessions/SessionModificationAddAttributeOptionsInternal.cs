using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SessionModificationAddAttributeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionAttribute;

	private SessionAttributeAdvertisementType m_AdvertisementType;

	public AttributeData SessionAttribute
	{
		[CalledBy(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(AttributeDataInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public SessionAttributeAdvertisementType AdvertisementType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "set_SessionAttribute")]
	public void Set(SessionModificationAddAttributeOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionModificationAddAttributeOptionsInternal), Member = "set_SessionAttribute")]
	[CalledBy(Type = typeof(SessionModification), Member = "AddAttribute")]
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
