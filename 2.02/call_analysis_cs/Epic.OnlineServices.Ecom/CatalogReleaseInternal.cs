using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct CatalogReleaseInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_CompatibleAppIdCount;

	private IntPtr m_CompatibleAppIds;

	private uint m_CompatiblePlatformCount;

	private IntPtr m_CompatiblePlatforms;

	private IntPtr m_ReleaseNote;

	public string[] CompatibleAppIds
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string[] CompatiblePlatforms
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string ReleaseNote
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatibleAppIds")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatiblePlatforms")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_ReleaseNote")]
	public void Set(CatalogRelease other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatibleAppIds")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatiblePlatforms")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_ReleaseNote")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
