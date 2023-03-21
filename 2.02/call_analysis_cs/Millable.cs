using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Millable : MonoBehaviour
{
	[Serializable]
	private class SaveData
	{
		public float m_RestorationProgress;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SaveData()
		{
		}
	}

	public GearItem[] m_RepairRequiredGear;

	public int[] m_RepairRequiredGearUnits;

	public GearItem[] m_RestoreRequiredGear;

	public int[] m_RestoreRequiredGearUnits;

	public bool m_CanRestoreFromWornOut;

	public int m_RepairDurationMinutes;

	public int m_RecoveryDurationMinutes;

	public SkillType m_Skill;

	private float _003Cm_RestorationProgress_003Ek__BackingField;

	public float m_RestorationProgress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ApplyRestorationProgress(float percentOfRemaining)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetRestorationProgress()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Millable()
	{
	}
}
