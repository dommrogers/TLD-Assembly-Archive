using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerDamageEvent : MonoBehaviour
{
	private static Panel_HUD s_HUD;

	public UISprite m_Icon;

	public UISprite m_Background;

	public UISprite m_Backpiece;

	public UILabel m_DamageType;

	public UILabel m_DamageName;

	public float m_DisplayTime;

	public float m_FadeOutTime;

	public float m_TimeActive;

	public bool m_FadeOut;

	public bool m_TintIcon;

	public bool m_TintDamageType;

	public bool m_TintDamageName;

	public bool m_TintBG;

	public Color m_BGColorRed;

	public Color m_BGColorOrange;

	public Color m_BGColorGreen;

	public Color m_BGColorWhite;

	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void SetAlpha(float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 1)]
	public PlayerDamageEventProxy ToProxy()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void FromProxy(PlayerDamageEventProxy proxy)
	{
	}

	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	private static bool HasHUD()
	{
		return false;
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "HasHUD")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "TintToBGColor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void SpawnDamageEvent(string damageEventName, string damageEventType, string iconName, Color tint, bool fadeout, float displayTime, float fadeoutTime)
	{
	}

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "HasHUD")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 2)]
	public static void SpawnAfflictionEvent(string damageEventName, string damageEventType, string iconName, Color tint)
	{
	}

	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Color TintToBGColor(PlayerDamageEvent damageEvent, Color tint)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerDamageEvent()
	{
	}
}
