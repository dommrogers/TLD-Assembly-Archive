using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Sprains : MonoBehaviour
{
	public class SaveDataProxy
	{
		public bool m_HadSprainRiskAffliction;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	private PanelReference<Panel_HUD> m_HUD;

	private SaveDataProxy m_SaveDataProxy;

	private float m_SecondsOnSlope;

	private float m_SecondsOffSlope;

	private float m_SecondsSprainRisk;

	private bool m_HadSprainRiskAffliction;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	private void MaybeSprainWhileMoving()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[CallerCount(Count = 0)]
	private void UpdateSprainRiskWarning(float slopeDegrees)
	{
	}

	[CallerCount(Count = 0)]
	private float ComputeSprainChanceForSlope(float slopeDegrees)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsUnknownMethods(Count = 1)]
	private float ComputeSprainChanceForEncumberance()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float ComputeSprainChanceForExhaustion()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	private float ModifyChanceForSprinting(float sprainChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallsUnknownMethods(Count = 2)]
	private float ModifyChanceForCrouching(float sprainChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private bool AreSprainsFromSlopesBlocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsSlopeWarningShowing()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowSlopeWarning(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	private bool RollForSprainWhenMoving(float sprainChance)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSprainWrist()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSprainAnkle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskAffliction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	public bool HasSprainsRiskAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	public string GetSprainRiskAfflictionReason()
	{
		return null;
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	private void UpdateSprainRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Sprains()
	{
	}
}
