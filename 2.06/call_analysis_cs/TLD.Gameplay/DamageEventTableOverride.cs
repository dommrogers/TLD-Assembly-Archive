using System;
using TLD.GameplayTags;

namespace TLD.Gameplay;

[Serializable]
public struct DamageEventTableOverride
{
	public GameplayTag m_AITag;

	public DamageEventTable m_Table;
}
