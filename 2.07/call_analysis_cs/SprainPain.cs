using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class SprainPain : MonoBehaviour
{
	private struct Instance
	{
		public AfflictionBodyArea m_Location;

		public string m_Cause;

		public float m_EndTime;
	}

	public class SaveDataProxy
	{
		public float m_SecondsSinceLastPulseFx;

		public int[] m_Locations;

		public string[] m_Causes;

		public float[] m_EndTimes;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveDataProxy()
		{
		}
	}

	private float m_AfflictionDurationHours;

	private float m_TreatmentPercent;

	private float m_PulseFxStartDelaySeconds;

	private float m_PulseFxFrequencySeconds;

	private float m_PulseFxIntensity;

	private string m_PulseFxWwiseRtpcName;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private List<Instance> m_ActiveInstances;

	private SaveDataProxy m_SaveDataProxy;

	private float m_SecondsSinceLastPulseFx;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	public bool HasSprainPain()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresPainKiller()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 5)]
	public void ApplyAffliction(AfflictionBodyArea location, string cause, AfflictionOptions opts = (AfflictionOptions)3)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SprainPain), Member = "Cure")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(SprainPain), Member = "Update")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CureAffliction(Instance inst)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void Cure()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetRemainingHours(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public void TakePainKillers(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	public string GetCauseLocId(int index)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public SprainPain()
	{
	}
}
