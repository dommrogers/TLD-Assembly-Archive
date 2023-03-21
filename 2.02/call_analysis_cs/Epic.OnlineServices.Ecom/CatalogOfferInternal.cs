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
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string CatalogNamespace
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Id
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		set
		{
		}
	}

	public string TitleText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DescriptionText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string TechnicalDetailsText_DEPRECATED
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		set
		{
		}
	}

	public string CurrencyCode
	{
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
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
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint CurrentPrice
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
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
			return default(byte);
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
		[CallerCount(Count = 5)]
		get
		{
			return default(long);
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
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AvailableForPurchase
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(CatalogOffer), Member = "Set")]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CatalogOfferInternal), Member = "Set")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_AvailableForPurchase")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_CurrencyCode")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_TechnicalDetailsText_DEPRECATED")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_LongDescriptionText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_Id")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_TitleText")]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_CatalogNamespace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "set_DescriptionText")]
	public void Set(CatalogOffer other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CatalogOfferInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
