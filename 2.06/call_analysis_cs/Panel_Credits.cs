using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI;
using UnityEngine;

public class Panel_Credits : Panel_AutoReferenced
{
	public enum CreditType
	{
		Undefined,
		Sprite,
		Header1,
		Header2,
		TitledName,
		Name,
		CenteredTitle,
		CenteredName,
		CenteredSubName,
		Message,
		Space,
		Texture,
		Headline
	}

	[Serializable]
	private class AtlasReference
	{
		public string m_Id;

		public UIAtlas m_Atlas;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public AtlasReference()
		{
		}
	}

	[Serializable]
	private class TextureReference
	{
		public string m_Id;

		public Texture2D m_Texture;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public TextureReference()
		{
		}
	}

	[Serializable]
	private class CreditTypePrefabMap
	{
		public CreditType m_Type;

		public CreditElement m_Prefab;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public CreditTypePrefabMap()
		{
		}
	}

	[Serializable]
	private class EpisodeDefinition
	{
		public TextAsset m_CreditsSource;

		public string m_MusicID;

		public GameObject m_BackgroundElementGroup;

		public float m_FadeInDuration;

		public float m_ElementsFadeInDuration;

		public float m_ElementsFadeInDelay;

		public float m_InitialScrollOffset;

		public int m_ScrollSpeed;

		public float m_ScrollDelay;

		public float m_EndPadding;

		[NonSerialized]
		public List<LineDefinition> m_Lines;

		[NonSerialized]
		public float m_FinalYOffset;

		private const int MAX_CONTENT_SIZE = 4;

		[CallerCount(Count = 0)]
		public float GetEndScrollValue()
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool HasLines()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
		[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
		[Calls(Type = typeof(LineDefinition), Member = ".ctor")]
		[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
		[CalledBy(Type = typeof(Panel_Credits), Member = "SetActiveEpisode")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
		[CallsUnknownMethods(Count = 18)]
		public void BuildLines()
		{
		}

		[CallerCount(Count = 0)]
		public EpisodeDefinition()
		{
		}
	}

	private class LineDefinition
	{
		public CreditType m_CreditType;

		public string[] m_Content;

		private bool m_IsEmpty;

		[CalledBy(Type = typeof(EpisodeDefinition), Member = "BuildLines")]
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public LineDefinition(BetterList<string> line, int contentSize)
		{
		}

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public bool IsEmpty()
		{
			return default(bool);
		}
	}

	private enum PanelState
	{
		FadingInPanel,
		StartingMusic,
		FadingInElements,
		Playing,
		Ending
	}

	private EpisodeDefinition[] m_EpisodeDefinitions;

	private CreditTypePrefabMap[] m_CreditTypePrefabs;

	private AtlasReference[] m_AtlasReferences;

	private TextureReference[] m_TextureReferences;

	private Transform m_ScrollArea;

	private float m_ScrollSmoothingTime;

	private float m_FastScrollMultiplier;

	private UIPanel m_MainPanel;

	private UIPanel m_CreditTextPanel;

	private Camera m_BackgroundRenderCamera;

	private UITexture m_BackgroundRenderer;

	private Vector2 m_MaxBackgroundRenderTextureSize;

	private uint m_MusicPlayingID;

	private string m_ForcedMusicID;

	private int m_MusicStartOffsetMs;

	private PanelState m_PanelState;

	private float m_ElementsStartTime;

	private bool m_SkipFadeIn;

	private float m_FadeInAmount;

	private float m_ElementsFadeInAmount;

	private float m_ScrollStartTime;

	private float m_ScrollVelocity;

	private float m_CurrentScrollSpeed;

	private float m_ScrollMultiplier;

	private EpisodeDefinition m_ActiveEpisode;

	private Action m_FadedInAction;

	private Action m_ExitAction;

	private RenderTexture m_BackgroundRenderTexture;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	public void ShowCredits(int episodeIndex, string forcedMusicID, int musicStartOffsetMs, uint musicPlayingID, bool skipFadeIn, Action fadedInAction, Action exitAction)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ShowCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "HandleOnCreditsLoaded")]
	[Calls(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[Calls(Type = typeof(EpisodeDefinition), Member = "BuildLines")]
	[Calls(Type = typeof(Panel_Credits), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Credits), Member = "BuildCreditElements")]
	public void ShowCredits(int episodeIndex, Action fadedInAction, Action exitAction)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFullyActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Credits), Member = "FadeInPanel")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeInPanel")]
	[Calls(Type = typeof(Panel_Credits), Member = "StartMusic")]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeIn")]
	[Calls(Type = typeof(Panel_Credits), Member = "Play")]
	[Calls(Type = typeof(Panel_Credits), Member = "Exit")]
	[Calls(Type = typeof(Panel_Credits), Member = "Exit")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeIn")]
	private void FadeInPanel(float panelFadeInDuration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeIn")]
	[CallsUnknownMethods(Count = 6)]
	private void FadeInElements()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Credits), Member = "FadeInPanel")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "FadeInElements")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void FadeIn(UIPanel panel, PanelState nextState, float startTime, float fadeInDuration, ref float fadeInAmount, ref float nextStateStartTime, Action onComplete)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "MuteGameplayAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void StartMusic()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void EnableBackgroundElementsGroup()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void Play()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public UIAtlas GetAtlasById(string id)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Texture2D GetTextureById(string id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool IsEditingPrefab()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Credits), Member = "Reset")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	private void Exit()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void StopMusic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private CreditElement GetCreditElementPrefab(CreditType creditType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EpisodeDefinition), Member = "BuildLines")]
	[Calls(Type = typeof(Panel_Credits), Member = "BuildCreditElements")]
	[CallsUnknownMethods(Count = 1)]
	private void SetActiveEpisode(EpisodeDefinition episodeDefinition)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private void Reset()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "SetActiveEpisode")]
	[CallsUnknownMethods(Count = 17)]
	private void BuildCreditElements(EpisodeDefinition episode)
	{
	}

	[CallerCount(Count = 0)]
	public Panel_Credits()
	{
	}
}
