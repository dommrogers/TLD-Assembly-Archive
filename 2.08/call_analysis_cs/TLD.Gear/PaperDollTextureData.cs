using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

public class PaperDollTextureData : ScriptableObject
{
	[Serializable]
	public class PersonaConfig
	{
		public AssetReferenceTexture2D m_Normal;

		public AssetReferenceTexture2D m_Damaged;

		public AssetReferenceTexture2D m_Blend;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PersonaConfig()
		{
		}
	}

	private PersonaConfig m_Male;

	private PersonaConfig m_Female;

	[CallerCount(Count = 0)]
	public PersonaConfig GetSetup(VoicePersona persona)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PaperDollTextureData()
	{
	}
}
