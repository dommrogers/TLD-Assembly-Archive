using System;
using System.Collections;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomExperienceModeManager : MonoBehaviour
{
	public enum CustomTunableLMH
	{
		Low,
		Medium,
		High
	}

	public enum CustomTunableNLH
	{
		None,
		Low,
		High
	}

	public enum CustomTunableLMHV
	{
		Low,
		Medium,
		High,
		VeryHigh
	}

	public enum CustomTunableNLMH
	{
		None,
		Low,
		Medium,
		High
	}

	public enum CustomTunableNLMHV
	{
		None,
		Low,
		Medium,
		High,
		VeryHigh
	}

	public enum CustomTunableDayNightMultiplier
	{
		OneX,
		TwoX,
		ThreeX,
		FourX
	}

	public enum CustomTunableTimeOfDay
	{
		Dawn,
		Noon,
		Dusk,
		Midnight,
		Random
	}

	public enum CustomTunableDistance
	{
		Close,
		Medium,
		Far
	}

	public enum CustomTunableWeather
	{
		Clear,
		LightSnow,
		HeavySnow,
		Blizzard,
		LightFog,
		DenseFog,
		Random
	}

	private const int SHARING_STRING_LEN = 20;

	public float m_IndoorSpawnChance;

	public float[] m_AuroraChanceModifierList;

	public float[] m_WindSpeedModifierList;

	public float[] m_WindChangeFrequencyModifierList;

	public float[] m_BloodScentModifierList;

	public float[] m_WildlifeDetectionModifierList;

	public float[] m_WolfFleeModifierList;

	public float[] m_PlantSpawnChanceList;

	public float[] m_WildlifeRespawnTimeModifierList;

	public float[] m_ThirstScaleList;

	public float[] m_FatigueScaleList;

	public float[] m_ConditionRecoveryRestList;

	public float[] m_ConditionRecoveryAwakeList;

	public int[] m_EmptyContainerChanceList;

	public float[] m_SmellRangeList;

	public float[] m_StruggleDamageReceivedList;

	public float[] m_StruggleClothingDamageList;

	public float[] m_FishCatchTimeScaleMaxList;

	public int[] m_FishCatchTimeScaleDayStartList;

	public int[] m_FishCatchTimeScaleDayFinalList;

	public float[] m_ProportionalReduceMaxItemsList;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetSharingStringLengthWithDashes()
	{
		return default(int);
	}

	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "BitsToDecimal")]
	public static bool CreateCustomModeFromString(CustomExperienceMode customMode, string inputString)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[CallsUnknownMethods(Count = 155)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 84)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	public static string CreateStringFromCustomMode(CustomExperienceMode customMode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	private static int BitsToDecimal(BitArray bitArray, int startIndex, int length)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static int[] ConvertDecToBase(int decimalValue, int baseValue, int size)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	private static BitArray GetBitArrayFromDec(int decValue, int desiredLength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomExperienceModeManager()
	{
	}
}
