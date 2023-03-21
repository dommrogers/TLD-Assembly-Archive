using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BurnsElectric : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_MaxHitPointsReduction;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_ClothingDamagePerSecondMin;

	public float m_ClothingDamagePerSecondMax;

	public GameObject m_PainKillersPrefab;

	public GameObject m_BandagePrefab;

	public string m_BurnInitialDamageVO;

	public string m_BurnSecondaryDamageVO;

	public string m_BurnDamageReminderVO;

	public int[] m_BurnReminderTimesInSeconds;

	public string m_IconSpriteName;

	public float m_InitialDamageVOCooldown;

	private bool m_Active;

	private float m_ElapsedHours;

	private float m_DurationHours;

	private bool m_PainKillersTaken;

	private bool m_BandageApplied;

	private float m_ClothingDamagePerSecond;

	private bool m_StartHasBeenCalled;

	private int m_NumBurnRemindersPlayed;

	private float m_SecondsUntilNextBurnReminder;

	private float m_NextBurnInitialVOTimer;

	private static BurnsElectricSaveDataProxy m_BurnsElectricSaveDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BurnsElectric), Member = "MaybePlayBurnReminder")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void BurnsElectricStart(bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_burns_electric_cure")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "UpdateBurnsElectric")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "TakePainKillers")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyBandage")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void BurnsElectricEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasBurnsElectric()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public bool RequiresPainkillers()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	public void TakePainKillers()
	{
	}

	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallerCount(Count = 0)]
	public void ApplyBandage()
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 9)]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	[CallsUnknownMethods(Count = 4)]
	public void ApplyClothingDamage(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateBurnsElectric()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "Update")]
	[CallsUnknownMethods(Count = 11)]
	private void MaybePlayBurnReminder()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BurnsElectric()
	{
	}
}
