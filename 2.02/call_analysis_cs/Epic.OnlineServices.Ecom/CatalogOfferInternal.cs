using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 104)]
internal struct CatalogOfferInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_ServerIndex;

	private IntPtr m_CatalogNamespace;

	private IntPtr m_Id;

	private IntPtr m_TitleText;

	private IntPtr m_DescriptionText;

	private IntPtr m_LongDescriptionText;

	private IntPtr m_TechnicalDetailsText_DEPRECATED;

	private IntPtr m_CurrencyCode;

	private Result m_PriceResult;

	private uint m_OriginalPrice;

	private uint m_CurrentPrice;

	private byte m_DiscountPercentage;

	private long m_ExpirationTimestamp;

	private uint m_PurchasedCount;

	private int m_PurchaseLimit;

	private int m_AvailableForPurchase;

	public int ServerIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string CatalogNamespace
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Id
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string TitleText
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DescriptionText
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string TechnicalDetailsText_DEPRECATED
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string CurrencyCode
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Result PriceResult
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Result);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint OriginalPrice
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint CurrentPrice
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte DiscountPercentage
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long ExpirationTimestamp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return 0L;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint PurchasedCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int PurchaseLimit
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AvailableForPurchase
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_CatalogNamespace")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_Id")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_TitleText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_DescriptionText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_LongDescriptionText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_TechnicalDetailsText_DEPRECATED")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_CurrencyCode")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_AvailableForPurchase")]
	public void Set(CatalogOffer other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
