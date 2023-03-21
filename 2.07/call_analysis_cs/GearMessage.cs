using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

public class GearMessage : MonoBehaviour
{
	public enum QuickKey
	{
		None,
		Journal,
		Map
	}

	public class GearMessageInfo
	{
		public GearItem m_GearItem;

		public string m_GearPrefabName;

		public string m_HeaderText;

		public string m_Text;

		public Color m_Color;

		public float m_DisplayTime;

		public float m_StartAlpha;

		public bool m_GearIsOpened;

		public QuickKey m_EnableQuickKey;

		public bool m_ShowOnHUDOnly;

		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
		public GearMessageInfo(string prefabName, string header, string text, GearItem gearItem = null)
		{
		}
	}

	public class JournalMessageInfo
	{
		public string m_CategoryLocID;

		public KnowledgeCateogry m_Category;

		public string m_NameLocID;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public void Set(string categoryLocID, KnowledgeCateogry category, string nameLocID)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public JournalMessageInfo()
		{
		}
	}

	private PanelReference<Panel_Actions> m_Actions;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Map> m_Map;

	private static List<GearMessageInfo> m_GearMessageQueue;

	private static List<string> m_JournalMessageQueue;

	public static JournalMessageInfo m_JournalQuickKeyInfo;

	public static bool m_JournalQuickKeyActive;

	public static bool m_MapQuickKeyActive;

	private static float m_MessageLabelDisplayTimeSeconds;

	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	private static float m_MessageLabelAlpha;

	private static float m_MessageLabelFadeTimeSeconds;

	private static bool m_MessageShowOnHUDOnly;

	private static int m_JournalMessageQueueFrameCounter;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	private bool ShouldShowNextMessageInQueue()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShouldShowNextMessageInQueue")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsMapOrLogEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnBlueprintUnlocked(BlueprintData bp)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalQueueMessageWithQuickKey")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	public static void AddJournalQueueMessage(string categoryLocID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddJournalQueueMessageWithQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	public static void AddMessage(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public static void AddMessage(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 45)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true, GearItem gi = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessageWithQuickKey(string prefabName, string header, string message, QuickKey quickKey, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessage(string prefabName, string header, string message, Color color, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddMessage(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddMessageFadeIn(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AddMessageFadeIn(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetJournalQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	private static void AddMessageToQueue(Panel_HUD hud, GearMessageInfo newGearMessage, bool highPriority)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private static void ShowNextMessageInQueue(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static bool MessageExistsInQueue(string message)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static bool ShortenMessageTimeDueToQueue()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private static void AddJournalMessage()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldUseOffsetLocation(Panel_HUD hud, Panel_FeedFire feedFire, Panel_FirstAid firstAid)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearMessage()
	{
	}
}
