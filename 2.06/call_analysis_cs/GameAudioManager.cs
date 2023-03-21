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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
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

	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Start")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAll()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMissionListEntrySelected")]
	public static bool CanPlaySpecialUIEntrySound()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationFocus")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	public static void PauseAudioImmediate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void PauseAudio()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static void UnPauseAudio()
	{
	}

	[CallerCount(Count = 345)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIError()
	{
	}

	[CallerCount(Count = 326)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIButtonClick()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 74)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void PlayGUIButtonBack()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputManager), Member = "PauseGame")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BreakDown), Member = "PerformInteraction")]
	public static void PlayGUIMenuOpen()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnBack")]
	public static void PlayGUIMenuClose()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 87)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void PlayGUIScroll()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SelectToolByIndex")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolIncrease")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnToolDecrease")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIComboBoxScroll()
	{
	}

	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnValueChanged")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public static void PlayGUISlider()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(BasicMenu), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "SetHoverColor")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 4)]
	public static void PlayGUIMouseOver()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void PlayGuiConfirm()
	{
	}

	[CallerCount(Count = 237)]
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

	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelter")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanTo")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CallerCount(Count = 5)]
	public void ExitOcclusionTrigger(AudioOcclusionLevel level)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void SetAiStateSwitch(AiMode mode, EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static void SetCookingSlotSwitch(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "PlayImpactAudio")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(ArrowItem), Member = "PlayImpactAudio")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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

	[CalledBy(Type = typeof(Panel_Harvest), Member = "StartHarvest")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "OnBreakDown")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartQuarter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "StartHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetCuttingToolSwitch(GearItem gearItem, GameObject go)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	public static void SetWeaponTypeSwitch(StruggleBonus.StruggleWeaponType weaponType, GameObject go)
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static void SetFootwearSwitch(FootwearType footwearType, GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public static void SetCramponsSwitch(CramponsState cramponsState, GameObject go)
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 7)]
	public static void SetIndoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnEnvironmentChanged")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	public static void SetOutdoorEnvironmentSwitch(GameObject go)
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "UpdateTorchAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "UpdateLoopingAudioPosition")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "UpdateNoiseMakerAudioPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(FlareItem), Member = "UpdateFlareAudioPosition")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(FlyOver), Member = "MoveFlyover")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public static void SetAudioSourceTransform(GameObject owner, Transform t)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static void SetAudioSourceTransform(EmitterProxy ep, Transform t)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_dd")]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_DynamicSequenceOpen__SWIG_2")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static void PlayDynamicSequence(string soundID, GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDMission), Member = "Dequeue")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static uint PlaySoundWithPositionTracking(AK.Wwise.Event soundEvent, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_soundlogduration")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LoopTracker), Member = "PlayFromEventString")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartSingleRing")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlaySoundWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback, PlayOptions playOptions)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PlayAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static uint PlayVoiceWithPositionTracking(string soundID, GameObject go, AkCallbackManager.EventCallback eventCallback)
	{
		return default(uint);
	}

	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	public static uint PlaySound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 190)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public static uint PlaySound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioSeek")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[CalledBy(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[CalledBy(Type = typeof(CinematicManager), Member = "AudioSeek")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SeekOnEvent__SWIG_5")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void Seek(string soundID, int audioMs, GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public static uint PlaySound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	public static uint Play3DSound(AK.Wwise.Event soundEvent, GameObject go)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 64)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 1)]
	public static uint Play3DSound(string soundID, GameObject go)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomLoop")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnMeltSnow")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnBoil")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "PlayRandomClip")]
	[CalledBy(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	public static uint Play3DSound(uint soundID, GameObject go)
	{
		return default(uint);
	}

	[Calls(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(StoneItem), Member = "PlayImpactEffects")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public static void NotifyAiAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject GetSoundEmitterFromGameObject(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static EmitterProxy GetSoundEmitterProxyFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public static void MuteGameplayAudio()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "StopMusic")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnmuteGameplayAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBackButton")]
	public static uint MaybePlayOverrideCloseSound()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void EnsureEmitterIsRegistered(GameObject go)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	private static void EnsureEmitterIsRegistered(EmitterProxy ep)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayVideo), Member = "OnExecute")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_StopAll__SWIG_0")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "TriggerStopAllAudioCallbackFor")]
	public static void StopAllSoundsFromGameObject(GameObject go)
	{
	}

	[CallerCount(Count = 68)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	public static void SetRTPCValue(uint rtpcID, float rtpcValue, GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static void FadeInAudioOnSceneStart()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 2)]
	public static bool HasFadedInOnStart()
	{
		return default(bool);
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static void UnloadActiveEpisode()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	private static void TriggerStopAllAudioCallbackFor(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioComponentsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "AddAudioEmitterProxy")]
	private static EmitterProxy AddAudioComponents(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static bool GameObjectHasCollider(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	private void UpdateAudioOcclusion()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateAudioFade()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	private void SetHeavyOcclusion()
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnterOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanTo")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelter")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
	private void SetMediumOcclusion()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "ExitOcclusionTrigger")]
	[CalledBy(Type = typeof(AudioStateZoneTrigger), Member = "OnTriggerStay")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InstantiateWiseAudio()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_constraints")]
	private static void AddAudioComponentsInternal(EmitterProxy ep)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "AddAudioComponents")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private static EmitterProxy AddAudioEmitterProxy(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioFade")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioFade")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 2)]
	private static void SetRTPCAudioFade(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GameAudioManager()
	{
	}
}
