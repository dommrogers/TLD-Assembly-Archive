using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KeyRebindingButton : MonoBehaviour
{
	public UISprite m_SelectedSprite;

	public UILabel m_ValueLabel;

	public string m_ActionIDString;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "ConvertKeycodeToLabel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnKeyRebindButtonPress")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateKeyBindingTable")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateKeyBindingTable")]
	[CallsUnknownMethods(Count = 1)]
	public void SetValueLabel(string keycode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public KeyRebindingButton()
	{
	}
}
