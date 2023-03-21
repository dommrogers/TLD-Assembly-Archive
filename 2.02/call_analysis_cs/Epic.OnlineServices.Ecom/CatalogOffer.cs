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
			return default(int);
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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string Id
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
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public string TechnicalDetailsText_DEPRECATED
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 17)]
		set
		{
		}
	}

	public Result PriceResult
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(Result);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
			return default(uint);
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
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
			return default(byte);
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 20)]
		get
		{
			return default(long);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public uint PurchasedCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(uint);
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
			return default(int);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AvailableForPurchase
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_CurrencyCode")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_TechnicalDetailsText_DEPRECATED")]
	[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_AvailableForPurchase")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_LongDescriptionText")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_TitleText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_Id")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_CatalogNamespace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "get_DescriptionText")]
	internal void Set(CatalogOfferInternal? other)
	{
	}

	[Calls(Type = typeof(CatalogOffer), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CatalogOffer()
	{
	}
}
