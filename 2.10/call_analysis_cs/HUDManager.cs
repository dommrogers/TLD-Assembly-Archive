using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using TLD.SaveState;
using TLD.Scenes;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
	private sealed class _003CWaitToShowLocationReveal_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWaitToShowLocationReveal_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(SceneSet), Member = "get_LocalizedRegionGroupName")]
		[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
		[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
		[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
		[Calls(Type = typeof(Log), Member = "AddLocation")]
		[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
		[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static LogFilter s_LogFilter;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private static HudDisplayMode _003CHudDisplayMode_003Ek__BackingField;

	public static float m_AmmoGaugeDisplayTime;

	public static bool m_ShowDebugInfo;

	public static bool m_ShowDaysSurvived;

	private static string m_SlotToLoadOnStart;

	private float m_CrosshairAlpha;

	private float Crosshair_FadeTimeSeconds;

	private static HudManagerSaveDataProxy m_HudManagerSaveDataProxy;

	public static HudDisplayMode HudDisplayMode
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(HudDisplayMode);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponCamera")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetDebugText")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "GetDebugText")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 52)]
	public void UpdateDebugLines(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateSurvivalTimeLabel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallerCount(Count = 8)]
	public static bool DoNotRenderHUD()
	{
		return false;
	}

	[CallerCount(Count = 21)]
	public static void SetHUDDisplayMode(HudDisplayMode newDisplayMode)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void DisplayAmmoOnHUDForTime(float seconds)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateCrosshair(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldHideCrossHairs(Panel_HUD hud)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanEnableHud()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitToShowLocationReveal_003Ed__27))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator WaitToShowLocationReveal()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[CallsUnknownMethods(Count = 1)]
	private void TrackIndoorLocation(string location, bool isLocationNew)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckIfLoadingNewLocation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public HUDManager()
	{
	}
}
