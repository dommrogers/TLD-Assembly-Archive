using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CatalogItem : ISettable
{
	private string _003CCatalogNamespace_003Ek__BackingField;

	private string _003CId_003Ek__BackingField;

	private string _003CEntitlementName_003Ek__BackingField;

	private string _003CTitleText_003Ek__BackingField;

	private string _003CDescriptionText_003Ek__BackingField;

	private string _003CLongDescriptionText_003Ek__BackingField;

	private string _003CTechnicalDetailsText_003Ek__BackingField;

	private string _003CDeveloperText_003Ek__BackingField;

	private EcomItemType _003CItemType_003Ek__BackingField;

	private long _003CEntitlementEndTimestamp_003Ek__BackingField;

	public string CatalogNamespace
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

	public string Id
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public string TitleText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public string DescriptionText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string TechnicalDetailsText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string DeveloperText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public EcomItemType ItemType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(EcomItemType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long EntitlementEndTimestamp
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_CatalogNamespace")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_Id")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_EntitlementName")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_TitleText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_DescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_LongDescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_TechnicalDetailsText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_DeveloperText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void Set(CatalogItemInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogItem), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CatalogItem()
	{
	}
}
