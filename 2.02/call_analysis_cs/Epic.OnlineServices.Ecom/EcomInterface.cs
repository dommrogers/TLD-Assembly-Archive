using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public sealed class EcomInterface : Handle
{
	public const int CatalogitemApiLatest = 1;

	public const int CatalogitemEntitlementendtimestampUndefined = -1;

	public const int CatalogofferApiLatest = 2;

	public const int CatalogofferExpirationtimestampUndefined = -1;

	public const int CatalogreleaseApiLatest = 1;

	public const int CheckoutApiLatest = 1;

	public const int CheckoutMaxEntries = 10;

	public const int CheckoutentryApiLatest = 1;

	public const int CopyentitlementbyidApiLatest = 2;

	public const int CopyentitlementbyindexApiLatest = 1;

	public const int CopyentitlementbynameandindexApiLatest = 1;

	public const int CopyitembyidApiLatest = 1;

	public const int CopyitemimageinfobyindexApiLatest = 1;

	public const int CopyitemreleasebyindexApiLatest = 1;

	public const int CopyofferbyidApiLatest = 1;

	public const int CopyofferbyindexApiLatest = 1;

	public const int CopyofferimageinfobyindexApiLatest = 1;

	public const int CopyofferitembyindexApiLatest = 1;

	public const int CopytransactionbyidApiLatest = 1;

	public const int CopytransactionbyindexApiLatest = 1;

	public const int EntitlementApiLatest = 2;

	public const int EntitlementEndtimestampUndefined = -1;

	public const int GetentitlementsbynamecountApiLatest = 1;

	public const int GetentitlementscountApiLatest = 1;

	public const int GetitemimageinfocountApiLatest = 1;

	public const int GetitemreleasecountApiLatest = 1;

	public const int GetoffercountApiLatest = 1;

	public const int GetofferimageinfocountApiLatest = 1;

	public const int GetofferitemcountApiLatest = 1;

	public const int GettransactioncountApiLatest = 1;

	public const int ItemownershipApiLatest = 1;

	public const int KeyimageinfoApiLatest = 1;

	public const int QueryentitlementsApiLatest = 2;

	public const int QueryentitlementsMaxEntitlementIds = 32;

	public const int QueryoffersApiLatest = 1;

	public const int QueryownershipApiLatest = 2;

	public const int QueryownershipMaxCatalogIds = 32;

	public const int QueryownershiptokenApiLatest = 2;

	public const int QueryownershiptokenMaxCatalogitemIds = 32;

	public const int RedeementitlementsApiLatest = 1;

	public const int RedeementitlementsMaxIds = 32;

	public const int TransactionidMaximumLength = 64;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EcomInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EcomInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void Checkout(CheckoutOptions options, object clientData, OnCheckoutCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_Entitlement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyEntitlementById(CopyEntitlementByIdOptions options, out Entitlement outEntitlement)
	{
		outEntitlement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_Entitlement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyEntitlementByIndex(CopyEntitlementByIndexOptions options, out Entitlement outEntitlement)
	{
		outEntitlement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_Entitlement_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyEntitlementByNameAndIndex(CopyEntitlementByNameAndIndexOptions options, out Entitlement outEntitlement)
	{
		outEntitlement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemByIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_CatalogItem_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyItemById(CopyItemByIdOptions options, out CatalogItem outItem)
	{
		outItem = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemImageInfoByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_KeyImageInfo_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyItemImageInfoByIndex(CopyItemImageInfoByIndexOptions options, out KeyImageInfo outImageInfo)
	{
		outImageInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyItemReleaseByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyItemReleaseByIndex(CopyItemReleaseByIndexOptions options, out CatalogRelease outRelease)
	{
		outRelease = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferByIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_CatalogOffer_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyOfferById(CopyOfferByIdOptions options, out CatalogOffer outOffer)
	{
		outOffer = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_CatalogOffer_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyOfferByIndex(CopyOfferByIndexOptions options, out CatalogOffer outOffer)
	{
		outOffer = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_KeyImageInfo_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyOfferImageInfoByIndex(CopyOfferImageInfoByIndexOptions options, out KeyImageInfo outImageInfo)
	{
		outImageInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_CatalogItem_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyOfferItemByIndex(CopyOfferItemByIndexOptions options, out CatalogItem outItem)
	{
		outItem = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyTransactionById(CopyTransactionByIdOptions options, out Transaction outTransaction)
	{
		outTransaction = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyTransactionByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyTransactionByIndex(CopyTransactionByIndexOptions options, out Transaction outTransaction)
	{
		outTransaction = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetEntitlementsByNameCount(GetEntitlementsByNameCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetEntitlementsCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetEntitlementsCount(GetEntitlementsCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetItemImageInfoCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetItemImageInfoCount(GetItemImageInfoCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetItemReleaseCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetItemReleaseCount(GetItemReleaseCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetOfferCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetOfferCount(GetOfferCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetOfferImageInfoCount(GetOfferImageInfoCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetOfferItemCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetOfferItemCount(GetOfferItemCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetTransactionCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetTransactionCount(GetTransactionCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryEntitlements(QueryEntitlementsOptions options, object clientData, OnQueryEntitlementsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOffersOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryOffers(QueryOffersOptions options, object clientData, OnQueryOffersCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOwnershipOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryOwnership(QueryOwnershipOptions options, object clientData, OnQueryOwnershipCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryOwnershipToken(QueryOwnershipTokenOptions options, object clientData, OnQueryOwnershipTokenCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void RedeemEntitlements(RedeemEntitlementsOptions options, object clientData, OnRedeemEntitlementsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnCheckoutCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryEntitlementsCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryOffersCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryOwnershipCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryOwnershipTokenCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnRedeemEntitlementsCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_Checkout(IntPtr handle, IntPtr options, IntPtr clientData, OnCheckoutCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyEntitlementById(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyItemById(IntPtr handle, IntPtr options, ref IntPtr outItem);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outImageInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, IntPtr options, ref IntPtr outRelease);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyOfferById(IntPtr handle, IntPtr options, ref IntPtr outOffer);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, IntPtr options, ref IntPtr outOffer);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outImageInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, IntPtr options, ref IntPtr outItem);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyTransactionById(IntPtr handle, IntPtr options, ref IntPtr outTransaction);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, IntPtr options, ref IntPtr outTransaction);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetOfferCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetOfferItemCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_GetTransactionCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_QueryEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryEntitlementsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_QueryOffers(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOffersCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_QueryOwnership(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOwnershipCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_QueryOwnershipToken(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryOwnershipTokenCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Ecom_RedeemEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, OnRedeemEntitlementsCallbackInternal completionDelegate);

	[PreserveSig]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementById")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByIndex")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByNameAndIndex")]
	[CalledBy(Type = typeof(Transaction), Member = "CopyEntitlementByIndex")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_Entitlement_Release(IntPtr entitlement);

	[PreserveSig]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyItemById")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferItemByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem);

	[PreserveSig]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferById")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer);

	[PreserveSig]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyItemImageInfoByIndex")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferImageInfoByIndex")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease);
}
