using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerManagerSaveDataProxy
{
	public Vector3 m_SaveGamePosition;

	public Quaternion m_SaveGameRotation;

	public bool m_StartGearAppliedProxy;

	public int m_ItemInHandsInstanceID;

	public int m_LastUnequippedItemInstanceID;

	public bool m_InRunMode;

	public bool m_Ghost;

	public bool m_God;

	public bool m_CheatsUsed;

	public VoicePersona m_VoicePersona;

	public float m_CaloriesHarvestedToday;

	public float m_FreezingRateScale;

	public float m_FatigueRateScale;

	public float m_ConditonPercentBonus;

	public float m_FatigueBuffHoursRemaining;

	public float m_FatigueBuffHoursDuration;

	public float m_FreezingBuffHoursRemaining;

	public float m_FreezingBuffHoursDuration;

	public float m_ConditionRestBuffHoursRemaining;

	public float m_ConditionRestBuffHoursDuration;

	public string m_StartingRegionName;

	public int m_SelectedBlueprintItemIndexWorkbench;

	public int m_SelectedBlueprintItemIndexForge;

	public bool m_PlayerInVehicle;

	public Vector3 m_PlayerInVehicleCameraPos;

	public bool m_PlayerInSnowShelter;

	public bool m_PlayerInLeanTo;

	public float m_PumpkinPieBuffHoursRemaining;

	public float m_PumpkinPieBuffHoursDuration;

	public float m_PumpkinPieFreezingRateScale;

	public List<int> m_KnownCodes;

	public SerializableBounds m_LimitCampfiresToBounds;

	public bool m_StatusBarsLocked;

	public float m_ConditionPerHourBonus;

	public float m_ConditionPerHourHoursRemaining;

	public float m_ConditionPerHourHoursDuration;

	public string m_FatigueBuffCauseLocID;

	public bool m_ForceAIFlee;

	public bool m_SuspendConditionUpdate;

	public bool m_ForceHideDiscoveryText;

	public bool m_DisableAllSpeech;

	public bool m_HasSavedItemInHands;

	public bool m_RestoreSavedItemInHandsPending;

	public bool m_HasEverSprayPainted;

	[CalledBy(Type = typeof(PlayerManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public PlayerManagerSaveDataProxy()
	{
	}
}
