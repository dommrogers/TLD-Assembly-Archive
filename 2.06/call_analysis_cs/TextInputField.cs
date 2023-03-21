using System;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using UnityEngine;

public class TextInputField : MonoBehaviour
{
	public static bool m_IsShowingVirtualKeyboard;

	public static bool m_VirtualKeyboardDismissed;

	public string m_VirtualKeyboardDescriptionLocID;

	public uint m_MaxLength;

	public bool m_AllowBlankText;

	public bool m_AllowMultiLine;

	private BoxCollider m_Collider;

	private UILabel m_Label;

	private UIInput m_Input;

	private bool m_GamePadTextInputCallbackRegistered;

	private Callback<GamepadTextInputDismissed_t> m_OnSteamKeyboardCallback;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaxLength(uint length)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CalledBy(Type = typeof(TextInputField), Member = "Update")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	public void SetText(string textToSet)
	{
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallsUnknownMethods(Count = 1)]
	public string GetText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	public bool IsLockedIn()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(SteamUtils), Member = "ShowGamepadTextInput")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public void Select()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public Vector3 GetCursorLocation()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(TextInputField), Member = "UpdateInputString")]
	[Calls(Type = typeof(InteropHelp), Member = "PtrToStringUTF8")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_GetEnteredGamepadTextInput")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_GetEnteredGamepadTextLength")]
	private void OnSteamKeyboardCallback(GamepadTextInputDismissed_t callbackData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInputField), Member = "UpdateInputString")]
	private void ConsoleKeyboardCallback(bool success, string desiredString)
	{
	}

	[CalledBy(Type = typeof(TextInputField), Member = "ConsoleKeyboardCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(TextInputField), Member = "OnSteamKeyboardCallback")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateInputString(string desiredString)
	{
	}

	[CallerCount(Count = 0)]
	public TextInputField()
	{
	}
}
