using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionModificationAddAttributeOptions
{
	private AttributeData _003CSessionAttribute_003Ek__BackingField;

	private SessionAttributeAdvertisementType _003CAdvertisementType_003Ek__BackingField;

	public AttributeData SessionAttribute
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionModificationAddAttributeOptions()
	{
	}
}
