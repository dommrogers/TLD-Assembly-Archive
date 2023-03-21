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

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickNew")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Activate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Start")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnLoadStory")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisodeFadeCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_Story), Member = "DoFileJump")]
	public static void StopAll()
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudioImmediate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static void PauseAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static void UnPauseAudio()
	{
	}

	[CallerCount(Count = 268)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIError()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 345)]
	public static void PlayGUIButtonClick()
	{
	}

	[CallerCount(Count = 78)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIButtonBack()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(InputManager), Member = "PauseGame")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessInteraction")]
	public static void PlayGUIMenuOpen()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	public static void PlayGUIMenuClose()
	{
	}

	[CallerCount(Count = 89)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUIScroll()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnValueChanged")]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGUISlider()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	public static void PlayGUIMouseOver()
	{
	}

	[CallerCount(Count = 43)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 6)]
	public static void PlayGuiConfirm()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CallerCount(Count = 0)]
	public void EnterOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerExit")]
	public void ExitOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static void SetMaterialSwitch(string tag, GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Harvestable), Member = "DoHarvest")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	public static void SetFootwearSwitch(FootwearType footwearType, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static void SetCramponsSwitch(CramponsState cramponsState, GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	public static void SetIndoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void SetSwearFilterSwitch(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	public static void SetSwearFilterSwitchOnEmitter(GameObject emitter)
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateLoopingAudioPosition")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TorchItem), Member = "UpdateTorchAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(FlareItem), Member = "UpdateFlareAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdatePosition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_dd")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "DynamicSequenceLockPlaylist")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlayMusic(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(Condition), Member = "PlayDeathMusic")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayNearDeathMusic")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "Update")]
	public static uint PlayMusic(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_soundlogduration")]
	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 223)]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioSeek")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[CalledBy(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[CalledBy(Type = typeof(CinematicManager), Member = "AudioSeek")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(AuroraActivatedAudio), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	public static void MuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "StopMusic")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public static void UnmuteGameplayAudio()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	public static uint MaybePlayOverrideCloseSound()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 61)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	public static void SetAudioFade(float normalizedValue)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 3)]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	public static bool HasFadedInOnStart()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void LoadEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallsUnknownMethods(Count = 1)]
	public static void DebugLoadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnBack")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateMainState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	public static void UnloadActiveEpisode()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallerCount(Count = 2)]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioEmitterProxy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void UpdateAudioOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void UpdateAudioFade()
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	private void SetHeavyOcclusion()
	{
	}

	[CalledBy(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	private void SetMediumOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetMildOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetNoOcclusion()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void InstantiateWiseAudio()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CallerCount(Count = 2)]
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
