using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Audio;
using TLD.Gear;
using TLD.ModularElectrolizer;
using TLD.SaveState;
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
		SkipAt0SoundVolume
	}

	public delegate void OnStopAllAudioCallback(GameObject gameObject);

	public GameObject m_WiseAudioPrefab;

	public float m_FadeInAudioSeconds;

	public int m_StopAudioFadeOutMicroseconds;

	public AK.Wwise.Event m_ErrorAudio;

	public AK.Wwise.Event m_ButtonClickAudio;

	public AK.Wwise.Event m_ButtonBackAudio;

	public AK.Wwise.Event m_MenuOpenAudio;

	public AK.Wwise.Event m_MenuCloseAudio;

	public AK.Wwise.Event m_ScrollAudio;

	public AK.Wwise.Event m_ComboBoxScrollAudio;

	public AK.Wwise.Event m_SliderAudio;

	public AK.Wwise.Event m_MouseOver;

	public AK.Wwise.Event m_Confirm;

	private AudioMaterialTagMapping m_MaterialMapping;

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

	private static GameAudioManager _003CInstance_003Ek__BackingField;

	public static GameAudioManager Instance
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
	[Calls(Type = typeof(GameAudioManager), Member = "InstantiateWiseAudio")]
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
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CallerCount(Count = 3)]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudioImmediate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void UnPauseAudio()
	{
	}

	[CallerCount(Count = 313)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIError()
	{
	}

	[CallerCount(Count = 294)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIButtonClick()
	{
	}

	[CallerCount(Count = 76)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIButtonBack()
	{
	}

	[CalledBy(Type = typeof(BreakDown), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(InputManager), Member = "PauseGame")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIMenuClose()
	{
	}

	[CallerCount(Count = 91)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnValueChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUISlider()
	{
	}

	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIMouseOver()
	{
	}

	[CallerCount(Count = 48)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGuiConfirm()
	{
	}

	[CallerCount(Count = 242)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StopPlayingID(ref uint id, int fadeOutMilliseconds = 100)
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
	[CallerCount(Count = 0)]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "MaybePlayPlacedPotAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Switch), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AudioMaterialTagMapping), Member = "SetSwitchByTag")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetMaterialSwitch(string tag, GameObject go)
	{
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
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
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "UpdateFlareAudioPosition")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "UpdateTorchAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateLoopingAudioPosition")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_dd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(TypeFullName = "AkSoundEnginePINVOKE", Member = "CSharp_DynamicSequenceOpen__SWIG_2")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlayMusic(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Condition), Member = "Update")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[CalledBy(Type = typeof(Condition), Member = "PlayDeathMusic")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayNearDeathMusic")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
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
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlayMusic(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(LoopTracker), Member = "PlayFromEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static uint PlaySoundWithPositionTracking(AK.Wwise.Event soundEvent, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_soundlogduration")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(LoopTracker), Member = "PlayFromEventString")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return 0u;
	}

	[CallerCount(Count = 90)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return 0u;
	}

	[CallerCount(Count = 178)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(CinematicManager), Member = "AudioSeek")]
	[CalledBy(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioSeek")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "Fire")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(ArrowItem), Member = "Break")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCookNormalFood")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "MaybePlayPlacedPotAudio")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static uint Play3DSound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return 0u;
	}

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 1)]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[CalledBy(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DestroyGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CallerCount(Count = 48)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public static void MuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StopMusic")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnmuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static uint MaybePlayOverrideCloseSound()
	{
		return 0u;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	private static string TrimAudioEventString(string soundId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsUnknownMethods(Count = 1)]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsUnknownMethods(Count = 1)]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(TypeFullName = "AkSoundEnginePINVOKE", Member = "CSharp_StopAll__SWIG_0")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 71)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	public static void SetAudioFade(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	public static void StartAudioFadeIn(float duration)
	{
	}

	[CallerCount(Count = 0)]
	public static void StartAudioFadeOut(float duration)
	{
	}

	[CallerCount(Count = 0)]
	public static bool AudioIsPaused()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 2)]
	public static bool HasFadedInOnStart()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadEpisode(Episode episode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallsUnknownMethods(Count = 1)]
	public static void DebugLoadAllEpisodeBanks()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnloadActiveEpisode()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioEmitterProxy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAudioOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudioFade()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetHeavyOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetMediumOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetMildOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InstantiateWiseAudio()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsUnknownMethods(Count = 2)]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private static void SetRTPCAudioFade(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameAudioManager()
	{
	}
}
