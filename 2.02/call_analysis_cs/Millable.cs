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
		[CallerCount(Count = 2)]
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
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ApplyRestorationProgress(float percentOfRemaining)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public void Deserialize(string serialized)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetRestorationProgress()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
