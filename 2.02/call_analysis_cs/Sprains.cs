using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Sprains : MonoBehaviour
{
	public class SaveDataProxy
	{
		public bool m_HadSprainRiskAffliction;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[Calls(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	private void MaybeSprainWhileMoving()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSprainRiskWarning(float slopeDegrees)
	{
	}

	[CallerCount(Count = 0)]
	private float ComputeSprainChanceForSlope(float slopeDegrees)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSprainChanceForEncumberance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSprainChanceForExhaustion()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ModifyChanceForSprinting(float sprainChance)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float ModifyChanceForCrouching(float sprainChance)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private bool AreSprainsFromSlopesBlocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsSlopeWarningShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ShowSlopeWarning(bool enable)
	{
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool RollForSprainWhenMoving(float sprainChance)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSprainWrist()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSprainAnkle()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool HasSprainsRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string GetSprainRiskAfflictionReason()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSprainRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public Sprains()
	{
	}
}
