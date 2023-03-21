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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string Id
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public string DescriptionText
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	public string TechnicalDetailsText
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string DeveloperText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(CatalogItemInternal), Member = "get_LongDescriptionText")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_DeveloperText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_TechnicalDetailsText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_DescriptionText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_EntitlementName")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_Id")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_CatalogNamespace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "get_TitleText")]
	internal void Set(CatalogItemInternal? other)
	{
	}

	[Calls(Type = typeof(CatalogItem), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CatalogItem()
	{
	}
}
