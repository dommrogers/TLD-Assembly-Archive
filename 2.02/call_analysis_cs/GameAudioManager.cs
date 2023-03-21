using System;
using System.Collections.Generic;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class GameAudioManager : MonoBehaviour
{
	private enum AudioFadeState
	{
		FadedIn,
		FadedOut
	}

	public enum PlayOptions
	{
		None,
		SkipAt0SoundVolume,
		ApplySwearFilter
	}

	public delegate void OnStopAllAudioCallback(GameObject gameObject);

	public GameObject m_WiseAudioPrefab;

	public float m_FadeInAudioSeconds;

	public int m_StopAudioFadeOutMicroseconds;

	public string m_ErrorAudio;

	public string m_ButtonClickAudio;

	public string m_ButtonBackAudio;

	public string m_MenuOpenAudio;

	public string m_MenuCloseAudio;

	public string m_ScrollAudio;

	public string m_ComboBoxScrollAudio;

	public string m_SliderAudio;

	public string m_MouseOver;

	public string m_Confirm;

	public GameObject m_WiseAudio;

	private static float m_LastAudioFade;

	private static bool m_AudioPaused;

	private int m_InsideHeavyOcclusionTriggerCount;

	private int m_InsideMediumOcclusionTriggerCount;

	private int m_InsideMildOcclusionTriggerCount;

	private static int m_FramesSincePlayedButtonClick;

	private AudioOcclusionLevel m_CurrentAudioOcclusionLevel;

	public static List<OnStopAllAudioCallback> m_OnStopAllAudioCallbacks;

	private static AudioFadeState m_AudioFadeState;

	private static AudioFadeState m_AudioFadeRequestedState;

	private static float m_AudioFadeTimer;

	private static float m_AudioFadeDuration;

	public static string m_WwiseEventOnStart;

	public static bool m_WwiseFadeInOnStart;

	public static bool m_WwiseStopAllOnStart;

	private static SoundbankLoader s_EpisodeLoader;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "InstantiateWiseAudio")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DoFileJump")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisodeFadeCallback")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickNew")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Activate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StopAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudioImmediate()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void UnPauseAudio()
	{
	}

	[CallerCount(Count = 268)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIError()
	{
	}

	[CallerCount(Count = 345)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIButtonClick()
	{
	}

	[CallerCount(Count = 78)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIButtonBack()
	{
	}

	[CalledBy(Type = typeof(BreakDown), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(InputManager), Member = "PauseGame")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIMenuOpen()
	{
	}

	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIMenuClose()
	{
	}

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIScroll()
	{
	}

	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnValueChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUISlider()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIMouseOver()
	{
	}

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGuiConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	public void EnterOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	public void ExitOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetMaterialSwitch(string tag, GameObject go)
	{
	}

	[CalledBy(Type = typeof(Harvestable), Member = "DoHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetFootwearSwitch(FootwearType footwearType, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCramponsSwitch(CramponsState cramponsState, GameObject go)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetIndoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void SetSwearFilterSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetSwearFilterSwitchOnEmitter(GameObject emitter)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "UpdateFlareAudioPosition")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateLoopingAudioPosition")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "UpdateTorchAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_dd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "DynamicSequenceLockPlaylist")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 8)]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "MaybePlayStinger")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_sorrowmusic")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "PlaySorrowMusic")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForHappySuccess")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForSorrow")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForRopeClimbStress")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "CheckForBeingStalked")]
	[CalledBy(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Update")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlaySceneEnterMusic")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "PlayExploreMusic")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlayMusic(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CalledBy(Type = typeof(Condition), Member = "PlayDeathMusic")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayNearDeathMusic")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static uint PlayMusic(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_soundlogduration")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return 0u;
	}

	[CallerCount(Count = 223)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(CinematicManager), Member = "AudioSeek")]
	[CalledBy(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioSeek")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CallerCount(Count = 72)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[CalledBy(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
	[CalledBy(Type = typeof(AuroraActivatedAudio), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StopMusic")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void UnmuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static uint MaybePlayOverrideCloseSound()
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetAudioFade(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StartAudioFadeIn(float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StartAudioFadeOut(float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool AudioIsPaused()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasFadedInOnStart()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DebugLoadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateMainState")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickBack")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnloadActiveEpisode()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioEmitterProxy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateAudioOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudioFade()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetHeavyOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetMediumOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetMildOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetNoOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void InstantiateWiseAudio()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 31)]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void SetRTPCAudioFade(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GameAudioManager()
	{
	}
}
