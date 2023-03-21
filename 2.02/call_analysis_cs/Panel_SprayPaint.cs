using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class Panel_SprayPaint : Panel_Base
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
		[CallerCount(Count = 7)]
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

	private GearItem m_SprayPaintCanToUse;

	private static SprayPaintPanelSaveData m_SprayPaintPanelSaveData;

	private bool m_CanShowBanishmentGlyph;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnButtonCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanPlaceDecalOnMap(ProjectileType projectile)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsOnlyAllowedOneOfType(ProjectileType projectile)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AreAnyPlacedDecalsOfType")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsAlreadyPlacedInWorld(ProjectileType projectile)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public bool DoesShapeLocIDExist(string locName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string GetShapeLocNameID(ProjectileType projectile)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsUnknownMethods(Count = 3)]
	public ProjectileType GetSelectedDecalShape()
	{
		return default(ProjectileType);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnButtonConfirm()
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonCancel")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void ReturnToGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OnButtonScrollLeft()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(GearItem), Member = "OnWield")]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "OnWield")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessReloadAction")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(GridUI), Member = "Initialize")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(GridUI), Member = "AddItem")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 34)]
	public void Enable(bool enable, GearItem sprayPaintCan, bool bypassScreen)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetSelectedDecalShape")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	private bool IsValidSelection()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonCancel")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "DoesShapeLocIDExist")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetSelectedDecalShape")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsUsingNowhereToHideShapes()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	private ShapeInfo[] GetShapes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	[Calls(Type = typeof(GridUI), Member = "RefreshTable")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeShowShapeWillNotShowOnMapWarning(int selectedIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeShowCannotPlaceMoreThanOneWarning(int selectedIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_SprayPaint()
	{
	}
}
