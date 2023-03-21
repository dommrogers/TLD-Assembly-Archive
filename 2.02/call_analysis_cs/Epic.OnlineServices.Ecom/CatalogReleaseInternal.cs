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
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string[] CompatiblePlatforms
	{
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string ReleaseNote
	{
		[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CalledBy(Type = typeof(CatalogReleaseInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatibleAppIds")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_CompatiblePlatforms")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "set_ReleaseNote")]
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
