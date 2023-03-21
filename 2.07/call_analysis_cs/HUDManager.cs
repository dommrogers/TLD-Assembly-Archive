using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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

		[Calls(Type = typeof(Log), Member = "AddLocation")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
		[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
		[Calls(Type = typeof(SceneSet), Member = "get_LocalizedRegionGroupName")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public IEnumerator Start()
	{
		return null;
	}

	[Calls(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
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

	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallerCount(Count = 0)]
	public static void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetDebugText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponCamera")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void UpdateDebugLines(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateSurvivalTimeLabel")]
	public static bool DoNotRenderHUD()
	{
		return default(bool);
	}

	[CallerCount(Count = 22)]
	public static void SetHUDDisplayMode(HudDisplayMode newDisplayMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	public static void DisplayAmmoOnHUDForTime(float seconds)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateCrosshair(Panel_HUD hud)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	private bool ShouldHideCrossHairs(Panel_HUD hud)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanEnableHud()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CWaitToShowLocationReveal_003Ed__27))]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator WaitToShowLocationReveal()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "AddLocation")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void TrackIndoorLocation(string location, bool isLocationNew)
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckIfLoadingNewLocation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public HUDManager()
	{
	}
}
