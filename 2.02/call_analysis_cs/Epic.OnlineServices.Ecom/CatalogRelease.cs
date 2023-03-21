using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CatalogRelease : ISettable
{
	private string[] _003CCompatibleAppIds_003Ek__BackingField;

	private string[] _003CCompatiblePlatforms_003Ek__BackingField;

	private string _003CReleaseNote_003Ek__BackingField;

	public string[] CompatibleAppIds
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string[] CompatiblePlatforms
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string ReleaseNote
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CatalogRelease), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_CompatibleAppIds")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_CompatiblePlatforms")]
	[Calls(Type = typeof(CatalogReleaseInternal), Member = "get_ReleaseNote")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(CatalogReleaseInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CatalogRelease), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CatalogRelease()
	{
	}
}
