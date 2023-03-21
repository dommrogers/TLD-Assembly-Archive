using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
		public string m_GearPrefabName;

		public string m_HeaderText;

		public string m_Text;

		public Color m_Color;

		public float m_DisplayTime;

		public float m_StartAlpha;

		public bool m_GearIsOpened;

		public QuickKey m_EnableQuickKey;

		public bool m_ShowOnHUDOnly;

		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 1)]
		public GearMessageInfo(string prefabName, string header, string text)
		{
		}
	}

	public class JournalMessageInfo
	{
		public string m_CategoryLocID;

		public KnowledgeCateogry m_Category;

		public string m_NameLocID;

		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		public void Set(string categoryLocID, KnowledgeCateogry category, string nameLocID)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public JournalMessageInfo()
		{
		}
	}

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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GearMessage), Member = "ShouldShowNextMessageInQueue")]
	[Calls(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 51)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldShowNextMessageInQueue()
	{
		return false;
	}

	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalQueueMessageWithQuickKey")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void AddJournalQueueMessage(string categoryLocID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddJournalQueueMessageWithQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public static void AddMessage(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static void AddMessage(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessage(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessageWithQuickKey(string prefabName, string header, string message, QuickKey quickKey, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessage(string prefabName, string header, string message, Color color, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessage(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessageFadeIn(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AddMessageFadeIn(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetJournalQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private static void AddMessageToQueue(GearMessageInfo newGearMessage, bool highPriority)
	{
	}

	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 66)]
	private static void ShowNextMessageInQueue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static bool MessageExistsInQueue(string message)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static bool ShortenMessageTimeDueToQueue()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void AddJournalMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldUseOffsetLocation()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GearMessage()
	{
	}
}
