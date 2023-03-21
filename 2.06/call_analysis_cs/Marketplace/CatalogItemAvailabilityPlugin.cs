using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class CatalogItemAvailabilityPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_AcceptablePaymentInstrumentTypes(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint CatalogItemAvailability_AcceptablePaymentInstrumentTypes_Length(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr CatalogItemAvailability_AcceptablePaymentInstrumentTypes_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void CatalogItemAvailability_AcceptablePaymentInstrumentTypes_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_AvailabilityDescription(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_AvailabilityTitle(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint CatalogItemAvailability_ConsumableQuantity(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_ContentId(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr CatalogItemAvailability_CurrencyCode(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_DisplayListPrice(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_DisplayPrice(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_DistributionType(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int CatalogItemAvailability_IsPurchasable(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern double CatalogItemAvailability_ListPrice(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_OfferDisplayDataJson(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_OfferId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern double CatalogItemAvailability_Price(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_PromotionalText(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr CatalogItemAvailability_SignedOffer(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void CatalogItemAvailability_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CatalogItemAvailabilityPlugin()
	{
	}
}
