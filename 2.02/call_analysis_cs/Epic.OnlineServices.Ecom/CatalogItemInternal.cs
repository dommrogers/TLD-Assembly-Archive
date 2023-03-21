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
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Id
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string TitleText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DescriptionText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string LongDescriptionText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string TechnicalDetailsText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DeveloperText
	{
		[CalledBy(Type = typeof(CatalogItem), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(CatalogItemInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_CatalogNamespace")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_Id")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_EntitlementName")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_TitleText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_DescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_LongDescriptionText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_TechnicalDetailsText")]
	[Calls(Type = typeof(CatalogItemInternal), Member = "set_DeveloperText")]
	public void Set(CatalogItem other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogItemInternal), Member = "Set")]
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
