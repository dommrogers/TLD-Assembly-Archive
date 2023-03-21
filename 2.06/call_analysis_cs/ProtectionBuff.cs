using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ProtectionBuff : MonoBehaviour
{
	public ProtectionType m_ProtectionType;

	public string m_BuffSprite;

	public LocalizedString m_ProtectionBuffNameLocID;

	public LocalizedString m_ProtectionLossBuffNameLocID;

	public LocalizedString m_AfflictionDescriptionLocID;

	public LocalizedString m_AfflictionCauseLocID;

	public AfflictionBodyArea m_AfflicationBodyArea;

	public List<AfflictionBodyArea> m_BodyAreasToPreventBloodLossOn;

	public float m_AnimalDamageModifier;

	public float m_ClothingDamageModifier;

	public float m_BrokenRibRecoveryTimeModifier;

	[CallerCount(Count = 0)]
	public float GetAnimalDamageModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetClothingDamageModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetBrokenRibModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public ProtectionBuff()
	{
	}
}
