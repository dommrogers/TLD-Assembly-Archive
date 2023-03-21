using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ClothingDamageEvent : StruggleDamageEvent
{
	public float m_RipClothingDamageMin;

	public float m_RipClothingDamageMax;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerClothingDamageScale")]
	public override void OnExecute()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override bool IsLocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ClothingDamageEvent()
	{
	}
}
