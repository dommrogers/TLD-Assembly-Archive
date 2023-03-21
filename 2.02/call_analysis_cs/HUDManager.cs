using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
	public static HudDisplayMode m_HudDisplayMode;

	public static float m_AmmoGaugeDisplayTime;

	public static bool m_ShowDebugInfo;

	public static bool m_ShowDaysSurvived;

	public static bool m_ForceShowRegionReveal;

	private static bool m_DidSceneTransition;

	private static string m_SlotToLoadOnStart;

	private float m_CrosshairAlpha;

	private float Crosshair_FadeTimeSeconds;

	private bool m_HasDoneLocationReveal;

	private static HudManagerSaveDataProxy m_HudManagerSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[Calls(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsStoryMoviePlaying()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "get_Angle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Scene), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponCamera")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetDebugText")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(AkGameObj), Member = "GetDebugText")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "GetDebugText")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "GetDebugText")]
	[Calls(Type = typeof(LightingManager), Member = "GetDebugText")]
	[Calls(Type = typeof(RaycastManager), Member = "GetDebugText")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 46)]
	public void UpdateDebugLines()
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateSurvivalTimeLabel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool DoNotRenderHUD()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayAmmoOnHUDForTime(float seconds)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldShowClickHoldBackpiece")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 40)]
	private void UpdateCrosshair()
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool ShouldHideCrossHairs()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanEnableHud()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(HUDManager), Member = "ShouldShowRegionReveal")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeShowLocationReveal()
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldShowRegionReveal(bool isIndoorEnvironment, string activeSceneName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void TrackIndoorLocation(string location, bool isLocationNew)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckIfLoadingNewLocation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HUDManager()
	{
	}
}
