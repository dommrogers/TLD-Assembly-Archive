using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CatalogOffer : ISettable
{
	private int _003CServerIndex_003Ek__BackingField;

	private string _003CCatalogNamespace_003Ek__BackingField;

	private string _003CId_003Ek__BackingField;

	private string _003CTitleText_003Ek__BackingField;

	private string _003CDescriptionText_003Ek__BackingField;

	private string _003CLongDescriptionText_003Ek__BackingField;

	private string _003CTechnicalDetailsText_DEPRECATED_003Ek__BackingField;

	private string _003CCurrencyCode_003Ek__BackingField;

	private Result _003CPriceResult_003Ek__BackingField;

	private uint _003COriginalPrice_003Ek__BackingField;

	private uint _003CCurrentPrice_003Ek__BackingField;

	private byte _003CDiscountPercentage_003Ek__BackingField;

	private long _003CExpirationTimestamp_003Ek__BackingField;

	private uint _003CPurchasedCount_003Ek__BackingField;

	private int _003CPurchaseLimit_003Ek__BackingField;

	private bool _003CAvailableForPurchase_003Ek__BackingField;

	public int ServerIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string CatalogNamespace
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

	public string Id
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

	public string TechnicalDetailsText_DEPRECATED
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

	public string CurrencyCode
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

	public Result PriceResult
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(Result);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint OriginalPrice
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint CurrentPrice
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte DiscountPercentage
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long ExpirationTimestamp
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
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

	public uint PurchasedCount
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int PurchaseLimit
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AvailableForPurchase
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_CatalogNamespace")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_Id")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_TitleText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_DescriptionText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_LongDescriptionText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_TechnicalDetailsText_DEPRECATED")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_CurrencyCode")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_AvailableForPurchase")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	internal void Set(CatalogOfferInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogOffer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CatalogOffer()
	{
	}
}
