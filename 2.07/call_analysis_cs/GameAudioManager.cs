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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Update")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Start")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	public static void StopAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	public static void PauseAudioImmediate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CallsUnknownMethods(Count = 4)]
	public static void PauseAudio()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	public static void UnPauseAudio()
	{
	}

	[CallerCount(Count = 343)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIError()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 332)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void PlayGUIButtonClick()
	{
	}

	[CallerCount(Count = 74)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIButtonBack()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "PauseGame")]
	[CalledBy(Type = typeof(BreakDown), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CallerCount(Count = 6)]
	public static void PlayGUIMenuOpen()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "BuildFinished")]
	public static void PlayGUIMenuClose()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 86)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PlayGUIScroll()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnValueChanged")]
	public static void PlayGUISlider()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	public static void PlayGUIMouseOver()
	{
	}

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGuiConfirm()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 250)]
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

	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	public void ExitOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void SetMaterialSwitch(string tag, GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetFootwearSwitch(FootwearType footwearType, GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetCramponsSwitch(CramponsState cramponsState, GameObject go)
	{
	}

	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	public static void SetIndoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateLoopingAudioPosition")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(FlareItem), Member = "UpdateFlareAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(TorchItem), Member = "UpdateTorchAudioPosition")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdatePosition")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallerCount(Count = 1)]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_dd")]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_DynamicSequenceOpen__SWIG_2")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 4)]
	public static uint PlayMusic(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlayMusic(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LoopTracker), Member = "PlayFromEvent")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public static uint PlaySoundWithPositionTracking(AK.Wwise.Event soundEvent, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(LoopTracker), Member = "PlayFromEventString")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_soundlogduration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static uint PlaySound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return default(uint);
	}

	[CallerCount(Count = 193)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "AudioSeek")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioSeek")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 33)]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[CallsUnknownMethods(Count = 2)]
	public static uint Play3DSound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[CalledBy(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public static void MuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "StopMusic")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnmuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	public static uint MaybePlayOverrideCloseSound()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsUnknownMethods(Count = 1)]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_StopAll__SWIG_0")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 70)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	public static bool HasFadedInOnStart()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioEmitterProxy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	private void UpdateAudioOcclusion()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudioFade()
	{
	}

	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	private void SetHeavyOcclusion()
	{
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	private void SetMediumOcclusion()
	{
	}

	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	private void SetMildOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	private void SetNoOcclusion()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void InstantiateWiseAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	private static void SetRTPCAudioFade(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GameAudioManager()
	{
	}
}
