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

		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		public GearMessageInfo(string prefabName, string header, string text, GearItem gearItem = null)
		{
		}
	}

	public class JournalMessageInfo
	{
		public string m_CategoryLocID;

		public KnowledgeCateogry m_Category;

		public string m_NameLocID;

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
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
	[CallsUnknownMethods(Count = 11)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "IsMapOrLogEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldShowNextMessageInQueue()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearMessage), Member = "ShouldShowNextMessageInQueue")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	private bool IsMapOrLogEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	private void OnBlueprintUnlocked(BlueprintData bp)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalQueueMessageWithQuickKey")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	public static void AddJournalQueueMessage(string categoryLocID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddJournalQueueMessageWithQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	public static void AddMessage(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessage(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 45)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 6)]
	public static void AddMessage(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true, GearItem gi = null)
	{
	}

	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void AddMessageWithQuickKey(string prefabName, string header, string message, QuickKey quickKey, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 6)]
	public static void AddMessage(string prefabName, string header, string message, Color color, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AddMessage(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private static void AddMessageToQueue(Panel_HUD hud, GearMessageInfo newGearMessage, bool highPriority)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private static void ShowNextMessageInQueue(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private static void AddJournalMessage()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ShouldUseOffsetLocation(Panel_HUD hud, Panel_FeedFire feedFire, Panel_FirstAid firstAid)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GearMessage()
	{
	}
}
