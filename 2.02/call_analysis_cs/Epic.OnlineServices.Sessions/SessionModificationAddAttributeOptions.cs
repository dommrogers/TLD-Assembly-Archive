using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionModificationAddAttributeOptions
{
	private AttributeData _003CSessionAttribute_003Ek__BackingField;

	private SessionAttributeAdvertisementType _003CAdvertisementType_003Ek__BackingField;

	public AttributeData SessionAttribute
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SessionModificationAddAttributeOptions()
	{
	}
}
