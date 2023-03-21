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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SprainPain), Member = "CureAffliction")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetRTPCValue__SWIG_8")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	public bool HasSprainPain()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
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

	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void ApplyAffliction(AfflictionBodyArea location, string cause, AfflictionOptions opts = (AfflictionOptions)3)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SprainPain), Member = "Cure")]
	[CalledBy(Type = typeof(SprainPain), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetRemainingHours(int index)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void TakePainKillers(int index)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	public string GetCauseLocId(int index)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	public SprainPain()
	{
	}
}
