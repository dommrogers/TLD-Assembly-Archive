using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
	private sealed class _003CWaitToShowLocationReveal_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWaitToShowLocationReveal_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(Log), Member = "AddLocation")]
		[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
		[Calls(Type = typeof(MusicEventManager), Member = "PlayLocationSound")]
		[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(SceneSet), Member = "get_LocalizedRegionGroupName")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	public static HudDisplayMode m_HudDisplayMode;

	public static float m_AmmoGaugeDisplayTime;

	public static bool m_ShowDebugInfo;

	public static bool m_ShowDaysSurvived;

	private static string m_SlotToLoadOnStart;

	private float m_CrosshairAlpha;

	private float Crosshair_FadeTimeSeconds;

	private static HudManagerSaveDataProxy m_HudManagerSaveDataProxy;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	public IEnumerator Start()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
	public static void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetDebugText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "GetDebugText")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponCamera")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void UpdateDebugLines(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateSurvivalTimeLabel")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	public static bool DoNotRenderHUD()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowItemIcons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	public static void DisplayAmmoOnHUDForTime(float seconds)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 22)]
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
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallerCount(Count = 0)]
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

	[IteratorStateMachine(typeof(_003CWaitToShowLocationReveal_003Ed__22))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
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
