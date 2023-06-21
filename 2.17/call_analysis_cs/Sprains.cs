using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Sprains : MonoBehaviour
{
	public class SaveDataProxy
	{
		public bool m_HadSprainRiskAffliction;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeSprainWhileMoving()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Sprains), Member = "ShowSlopeWarning")]
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
	[CallsUnknownMethods(Count = 1)]
	private float ComputeSprainChanceForEncumberance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float ComputeSprainChanceForExhaustion()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsUnknownMethods(Count = 2)]
	private float ModifyChanceForSprinting(float sprainChance)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsSlopeWarningShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sprains), Member = "IsSlopeWarningShowing")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ShowSlopeWarning(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 3)]
	private bool RollForSprainWhenMoving(float sprainChance)
	{
		return false;
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

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasSprainsRiskAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSprainRiskAfflictionReason()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void UpdateSprainRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Sprains()
	{
	}
}
