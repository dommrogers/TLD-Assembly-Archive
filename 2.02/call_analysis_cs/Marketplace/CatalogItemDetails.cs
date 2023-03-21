using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class CatalogItemDetails : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private string m_Description;

	private string m_Id;

	private string m_ProductId;

	private string m_Name;

	private string m_ReducedName;

	private string m_SandboxId;

	private DateTime m_ReleaseDate;

	private CatalogItemImageList m_Images;

	private CatalogItemAvailabilityList m_Availabilities;

	public string Description
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Id
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public MediaItemType GetMediaItemType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(MediaItemType);
		}
	}

	public string ProductId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string ReducedName
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string SandboxId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public uint TitleId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public DateTime ReleaseDate
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedDateTime")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return default(DateTime);
		}
	}

	public CatalogItemImageList Images
	{
		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(CatalogItemImageList), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public CatalogItemAvailabilityList Availabilities
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CatalogItemDetails(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CatalogItemDetails()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 52)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
