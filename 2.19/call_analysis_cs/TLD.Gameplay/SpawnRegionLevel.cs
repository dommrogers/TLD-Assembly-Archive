using System;
using TLD.Gameplay.Tunable;
using TLD.GameplayTags;

namespace TLD.Gameplay;

[Serializable]
public struct SpawnRegionLevel
{
	public GameplayTag m_AITag;

	public CustomTunableNLMHV m_SpawnLevel;
}
