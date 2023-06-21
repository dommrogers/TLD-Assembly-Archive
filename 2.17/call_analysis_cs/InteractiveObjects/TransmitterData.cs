using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using TLD.Scenes.ObjectReferences;
using UnityEngine.AddressableAssets;

namespace InteractiveObjects;

public class TransmitterData : SceneObjectReference
{
	private string m_Guid;

	private string[] m_GuidAliases;

	private LocalizedString m_TransmitterName;

	private LocalizedString m_TransmitterDescription;

	private ZoneSpecification m_HomeZone;

	private AssetReferenceTexture2D m_RegionTexture;

	private AssetReferenceGameObject m_JournalMapItemPrefab;

	public string Guid
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
	}

	public LocalizedString TransmitterName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	public LocalizedString TransmitterDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
	}

	public AssetReferenceTexture2D RegionTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public AssetReferenceGameObject JournalMapItemPrefab
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
	}

	public WorldMapSpecification WorldMap
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAlsoKnownAs(string otherGuid)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneObjectReference), Member = ".ctor")]
	public TransmitterData()
	{
	}
}
