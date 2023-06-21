using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DishEffectInfoUI : ScriptableObject
{
	[Serializable]
	public struct DishEffectUIMapping
	{
		public IFoodEffect.EffectType m_EffectType;

		public string m_SpriteName;

		public LocalizedString m_EffectText;
	}

	public List<DishEffectUIMapping> m_Mappings;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DishEffectInfoUI()
	{
	}
}
