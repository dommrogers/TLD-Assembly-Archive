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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 18)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateText()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPreferredCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	public void SetChoiceCategoryConfiguration(DialogueModeRigFP.DialogueChoiceCategoryConfiguration categoryConfig)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnChoiceSelected")]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public void Reset(DialogueModeRigFP dialogueModeRigFP)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
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
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Setup(string text, int choiceIndex, float textSize)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	public void SetupImages(Texture2D fg, Texture2D bg)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableForeground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableBackground")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void EnableImage(Renderer renderer, Texture2D image)
	{
	}

	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableBackground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableForeground")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableImage(Renderer renderer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRenderComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsChoiceAssigned()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetHovered(bool isHovered)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHovered()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void SetupNormalUILabelText(string text, float textSize)
	{
	}

	[CallerCount(Count = 0)]
	public DialogueSequenceFP()
	{
	}
}
