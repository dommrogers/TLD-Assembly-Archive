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
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
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
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(GearMessage), Member = "ShouldShowNextMessageInQueue")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool ShouldShowNextMessageInQueue()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalQueueMessageWithQuickKey")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	public static void AddJournalQueueMessage(string categoryLocID)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void AddJournalQueueMessageWithQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallerCount(Count = 8)]
	public static void AddMessage(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessage(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 46)]
	public static void AddMessage(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddJournalMessage")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	public static void AddMessageWithQuickKey(string prefabName, string header, string message, QuickKey quickKey, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearMessageInfo), Member = ".ctor")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
	[CallsUnknownMethods(Count = 8)]
	public static void AddMessage(string prefabName, string header, string message, Color color, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageToQueue")]
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
	[CallsUnknownMethods(Count = 8)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void SetJournalQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GearMessage), Member = "AddMessage")]
	private static void AddMessageToQueue(GearMessageInfo newGearMessage, bool highPriority)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 66)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private static void ShowNextMessageInQueue()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static bool MessageExistsInQueue(string message)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsUnknownMethods(Count = 5)]
	private static bool ShortenMessageTimeDueToQueue()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageWithQuickKey")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static void AddJournalMessage()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private bool ShouldUseOffsetLocation()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GearMessage()
	{
	}
}
