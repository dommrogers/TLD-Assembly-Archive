using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionDetailsAttribute : ISettable
{
	private AttributeData _003CData_003Ek__BackingField;

	private SessionAttributeAdvertisementType _003CAdvertisementType_003Ek__BackingField;

	public AttributeData Data
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public SessionAttributeAdvertisementType AdvertisementType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(SessionAttributeAdvertisementType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "get_Data")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(SessionDetailsAttributeInternal? other)
	{
	}

	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "get_Data")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionDetailsAttribute()
	{
	}
}
