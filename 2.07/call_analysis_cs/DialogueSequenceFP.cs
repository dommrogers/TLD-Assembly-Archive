using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using TMPro;
using UnityEngine;

public class DialogueSequenceFP : MonoBehaviour
{
	private const int MAX_TEXT_SIZE = 255;

	public Color m_DefaultNormalColor;

	public Color m_DefaultHoveredColor;

	public UILabel m_UILabel;

	public Camera m_TextRenderingCamera;

	public Renderer m_Foreground;

	public Renderer m_Backround;

	private TextMeshPro m_TextMesh;

	private UIRoot m_UIRoot;

	private int m_ChoiceIndex;

	private DialogueModeRigFP m_DialogueModeRigFP;

	private bool m_IsChoiceEnabled;

	private bool m_IsChoiceAssigned;

	private string m_StateName;

	private float m_Duration;

	private DialogueModeRigFP.DialogueChoiceCategoryConfiguration m_DialogueChoiceCategoryConfiguration;

	private Dialogue_MultipleChoiceNode.ChoiceCategory m_PreferredCategory;

	private string m_DisplayName;

	private bool m_IsHovered;

	private bool m_HasChanged;

	private RenderTextureGrabber m_QuadRenderTextureGrabber;

	private Renderer m_QuadRenderer;

	private Vector3 m_QuadOriginalScale;

	private bool m_HasRequestedTextUpdate;

	private int m_OriginalFontSize;

	private float m_MaxTextSizeFactor;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	private void UpdateText()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPreferredCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	public void SetChoiceCategoryConfiguration(DialogueModeRigFP.DialogueChoiceCategoryConfiguration categoryConfig)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnChoiceSelected")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Reset(DialogueModeRigFP dialogueModeRigFP)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Dialogue_MultipleChoiceNode.ChoiceCategory GetPreferredCategory()
	{
		return default(Dialogue_MultipleChoiceNode.ChoiceCategory);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetChoiceIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void Setup(string text, int choiceIndex, float textSize)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	public void SetupImages(Texture2D fg, Texture2D bg)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableBackground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableForeground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	private void EnableImage(Renderer renderer, Texture2D image)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableForeground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableBackground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	private void DisableImage(Renderer renderer)
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenderComplete()
	{
	}

	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[CallerCount(Count = 0)]
	public void EnableForeground(Texture2D image)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	public void EnableBackground(Texture2D image)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	public void DisableBackground()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	public void DisableForeground()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetChoiceEnabled(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetChoiceAssigned(bool isAssigned)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsChoiceEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsChoiceAssigned()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void SetHovered(bool isHovered)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHovered()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	private void SetupNormalUILabelText(string text, float textSize)
	{
	}

	[CallerCount(Count = 0)]
	public DialogueSequenceFP()
	{
	}
}
