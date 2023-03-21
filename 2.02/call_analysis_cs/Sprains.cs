using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Sprains : MonoBehaviour
{
	public class SaveDataProxy
	{
		public bool m_HadSprainRiskAffliction;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SaveDataProxy()
		{
		}
	}

	private const int SLOPE_IGNORE_MASK = 2048;

	private readonly int m_AnimParameter_ShowSprainWarning;

	private bool m_IsDebugging;

	private float m_CheckSecondsIntervalWhileSprainRisk;

	private float m_ChanceOfWristSprainWhenMoving;

	private int m_MinSlopeDegreesForSprain;

	private float m_BaseChanceWhenMovingOnSlope;

	private float m_ChanceIncreaseEachDegreeAboveMinSlope;

	private float m_MinSecondsForSlopeRisk;

	private float m_ChanceIncreaseEncumbered;

	private float m_ChanceIncreaseExhausted;

	private float m_ChanceIncreaseSprinting;

	private float m_ChanceReduceWhenCrouchedPercent;

	private float m_MinSecondsToShowWarning;

	private float m_MinSecondsBeforeHidingWarning;

	private SaveDataProxy m_SaveDataProxy;

	private float m_SecondsOnSlope;

	private float m_SecondsOffSlope;

	private float m_SecondsSprainRisk;

	private bool m_HadSprainRiskAffliction;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void MaybeSprainWhileMoving()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	private void UpdateSprainRiskWarning(float slopeDegrees)
	{
	}

	[CallerCount(Count = 0)]
	private float ComputeSprainChanceForSlope(float slopeDegrees)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSprainChanceForEncumberance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSprainChanceForExhaustion()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float ModifyChanceForSprinting(float sprainChance)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float ModifyChanceForCrouching(float sprainChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private bool AreSprainsFromSlopesBlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsSlopeWarningShowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ShowSlopeWarning(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CallsUnknownMethods(Count = 4)]
	private bool RollForSprainWhenMoving(float sprainChance)
	{
		return default(bool);
	}

	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	private void MaybeSprainWrist()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSprainAnkle()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	public bool HasSprainsRiskAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallsUnknownMethods(Count = 4)]
	public string GetSprainRiskAfflictionReason()
	{
		return null;
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void UpdateSprainRiskAffliction()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Sprains()
	{
	}
}
