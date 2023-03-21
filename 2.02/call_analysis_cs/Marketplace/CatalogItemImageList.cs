using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class CatalogItemImageList : WrappedCachedList<CatalogItemImage>
{
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CatalogItem), Member = "get_Images")]
	[CalledBy(Type = typeof(CatalogItemDetails), Member = "get_Images")]
	[CallsUnknownMethods(Count = 1)]
	public CatalogItemImageList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public CatalogItemImageList()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~CatalogItemImageList()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override CatalogItemImage CreateIthElement(int i)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupLength()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void DisposeChild()
	{
	}
}
