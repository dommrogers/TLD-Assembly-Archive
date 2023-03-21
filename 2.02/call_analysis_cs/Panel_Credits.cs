using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Panel_Credits : Panel_Base
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
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 7)]
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
			return 0f;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool HasLines()
		{
			return false;
		}

		[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
		[CalledBy(Type = typeof(Panel_Credits), Member = "SetActiveEpisode")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
		[Calls(Type = typeof(ByteReader), Member = "ReadCSV")]
		[Calls(TypeFullName = "Panel_Credits.LineDefinition", Member = ".ctor")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 26)]
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

		[CalledBy(TypeFullName = "Panel_Credits.EpisodeDefinition", Member = "BuildLines")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "TryParse")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public LineDefinition(BetterList<string> line, int contentSize)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public bool IsEmpty()
		{
			return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	public void ShowCredits(int episodeIndex, string forcedMusicID, int musicStartOffsetMs, uint musicPlayingID, bool skipFadeIn, Action fadedInAction, Action exitAction)
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "HandleOnCreditsLoaded")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Action_ShowCredits), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Credits), Member = "Reset")]
	[Calls(Type = typeof(EpisodeDefinition), Member = "BuildLines")]
	[Calls(Type = typeof(Panel_Credits), Member = "BuildCreditElements")]
	[Calls(Type = typeof(Panel_Credits), Member = "Exit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ShowCredits(int episodeIndex, Action fadedInAction, Action exitAction)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFullyActive()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeIn")]
	private void FadeInPanel(float panelFadeInDuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Credits), Member = "FadeIn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void FadeInElements()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "FadeInPanel")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "FadeInElements")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void FadeIn(UIPanel panel, PanelState nextState, float startTime, float fadeInDuration, ref float fadeInAmount, ref float nextStateStartTime, Action onComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "MuteGameplayAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void StartMusic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableBackgroundElementsGroup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void Play()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public UIAtlas GetAtlasById(string id)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D GetTextureById(string id)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsEditingPrefab()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Credits), Member = "Reset")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Exit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "UnmuteGameplayAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopMusic()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "BuildCreditElements")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void Reset()
	{
	}

	[CalledBy(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "SetActiveEpisode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Credits), Member = "GetCreditElementPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private void BuildCreditElements(EpisodeDefinition episode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Credits()
	{
	}
}
