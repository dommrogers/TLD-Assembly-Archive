using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class FoodMaxStatBuffManager : MonoBehaviour
{
	private Vector2 m_ConditionMinMax;

	private Vector2 m_StaminaMinMax;

	private List<FoodMaxStatBuffEffect> _003CActiveEffects_003Ek__BackingField;

	private static FoodMaxStatBuffManager _003CInstance_003Ek__BackingField;

	private int m_LongestDebuffIndex;

	private int m_LongestBuffIndex;

	public List<FoodMaxStatBuffEffect> ActiveEffects
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	public static FoodMaxStatBuffManager Instance
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "UpdateLongestActiveEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(List<FoodMaxStatBuffEffect> serializedEffects)
	{
	}

	[CalledBy(Type = typeof(FoodMaxStatBuff), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "GetStatBuff")]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "UpdateLongestActiveEffects")]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[Calls(Type = typeof(Condition), Member = "DisplayConditionOnHUDForTime")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool AddStatBuff(FoodMaxStatBuff.StatType stat, float buff, float hoursActive, bool canStack = true)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[Calls(Type = typeof(Condition), Member = "DisplayConditionOnHUDForTime")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsUnknownMethods(Count = 3)]
	private void AddStatValue(FoodMaxStatBuff.StatType stat, float statValue)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetMaxSprintStaminaModifier")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatBuff")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 7)]
	public float GetStatBuff(FoodMaxStatBuff.StatType stat)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private Vector2 GetMinMax(FoodMaxStatBuff.StatType stat)
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasAnyBuff()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasAnyDebuff()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetBuffTimeLeftHours()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDebuffTimeLeftHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedBuffDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedDebuffDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "UpdateLongestActiveEffects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatBuff")]
	[CalledBy(Type = typeof(FoodMaxStatBuffManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLongestActiveEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public FoodMaxStatBuffManager()
	{
	}
}
