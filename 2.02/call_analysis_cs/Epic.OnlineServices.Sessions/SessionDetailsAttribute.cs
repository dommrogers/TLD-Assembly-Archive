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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
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
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "get_Data")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(SessionDetailsAttributeInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsAttributeInternal), Member = "get_Data")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SessionDetailsAttribute()
	{
	}
}
