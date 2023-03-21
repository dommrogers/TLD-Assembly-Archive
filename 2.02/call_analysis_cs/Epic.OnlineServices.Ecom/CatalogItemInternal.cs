using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 88)]
internal struct CatalogItemInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_CatalogNamespace;

	private IntPtr m_Id;

	private IntPtr m_EntitlementName;

	private IntPtr m_TitleText;

	private IntPtr m_DescriptionText;

	private IntPtr m_LongDescriptionText;

	private IntPtr m_TechnicalDetailsText;

	private IntPtr m_DeveloperText;

	private EcomItemType m_ItemType;

	private long m_EntitlementEndTimestamp;

	public string CatalogNamespace
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		set
		{
		}
	}

	public string Id
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		set
		{
		}
	}

	public string TitleText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
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
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		set
		{
		}
	}

	public string TechnicalDetailsText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string DeveloperText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		set
		{
		}
	}

	public EcomItemType ItemType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return default(EcomItemType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public long EntitlementEndTimestamp
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return default(long);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_CatalogNamespace")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_Id")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_EntitlementName")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_TitleText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_DescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_LongDescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_TechnicalDetailsText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_DeveloperText")]
	[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
	public void Set(CatalogItem other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
