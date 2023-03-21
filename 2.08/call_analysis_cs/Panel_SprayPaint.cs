using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_SprayPaint : Panel_AutoReferenced
{
	[Serializable]
	public struct ShapeInfo
	{
		public ProjectileType ProjectileType;

		public LocalizedString m_Label;

		public Texture m_ShapeIcon;

		public bool m_AddedToMap;

		public bool m_OnlyAllowedOneOfType;
	}

	public class SprayPaintPanelSaveData
	{
		public ProjectileType m_LastSelectedShape;

		public bool m_CanShowBanishmentGlyph;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SprayPaintPanelSaveData()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_ShapeNotMappedMessage;

	public UILabel m_CannotPlaceMoreThanOneMessage;

	private ShapeInfo[] m_Shapes;

	private ShapeInfo[] m_NowhereToHideEventShapes;

	private GridUI m_ShapeGridUI;

	private ProjectileType m_LastSelectedShape;

	public GameObject[] m_MouseButtons;

	private PanelReference<Panel_HUD> m_HUD;

	private GearItem m_SprayPaintCanToUse;

	private static SprayPaintPanelSaveData m_SprayPaintPanelSaveData;

	private bool m_CanShowBanishmentGlyph;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnButtonCancel()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPlaceDecalOnMap(ProjectileType projectile)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOnlyAllowedOneOfType(ProjectileType projectile)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AreAnyPlacedDecalsOfType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	public bool IsAlreadyPlacedInWorld(ProjectileType projectile)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public bool DoesShapeLocIDExist(string locName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	public string GetShapeLocNameID(ProjectileType projectile)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsUnknownMethods(Count = 2)]
	public ProjectileType GetSelectedDecalShape()
	{
		return default(ProjectileType);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void OnButtonConfirm()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonCancel")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private void ReturnToGame()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnButtonScrollLeft()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnButtonScrollRight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(GearItem), Member = "OnWield")]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "OnWield")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessReloadAction")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(GridUI), Member = "Initialize")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[Calls(Type = typeof(GridUI), Member = "AddItem")]
	public void Enable(bool enable, GearItem sprayPaintCan, bool bypassScreen)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public void SetShowBanishmentGlyph(bool show)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanShowBanishmentGlyph()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetSelectedDecalShape")]
	private bool IsValidSelection()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private bool IsUsingNowhereToHideShapes()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	private ShapeInfo[] GetShapes()
	{
		return null;
	}

	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GridUI), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(GridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[Calls(Type = typeof(GridUI), Member = "RefreshGridItem")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	private void MaybeShowShapeWillNotShowOnMapWarning(int selectedIndex)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	private void MaybeShowCannotPlaceMoreThanOneWarning(int selectedIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void UpdateControls()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_SprayPaint()
	{
	}
}
