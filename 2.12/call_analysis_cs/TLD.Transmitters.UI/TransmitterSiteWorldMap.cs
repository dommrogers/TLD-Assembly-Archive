using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Transmitters.UI;

public class TransmitterSiteWorldMap : MonoBehaviour
{
	private WorldMapSpecification m_WorldMap;

	public WorldMapSpecification WorldMap
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TransmitterSiteWorldMap()
	{
	}
}
