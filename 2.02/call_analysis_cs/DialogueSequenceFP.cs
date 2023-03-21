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

	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	private void UpdateText()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	public void SetChoiceCategoryConfiguration(DialogueModeRigFP.DialogueChoiceCategoryConfiguration categoryConfig)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnChoiceSelected")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public void Reset(DialogueModeRigFP dialogueModeRigFP)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "SetupNormalUILabelText")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "UpdateText")]
	[CallsUnknownMethods(Count = 1)]
	public void Setup(string text, int choiceIndex, float textSize)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "EnableImage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueSequenceFP), Member = "DisableImage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetupImages(Texture2D fg, Texture2D bg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 9)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableBackground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "EnableForeground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	private void EnableImage(Renderer renderer, Texture2D image)
	{
	}

	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableForeground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "DisableBackground")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetupImages")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "SetChoiceCategoryConfiguration")]
	private void DisableImage(Renderer renderer)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
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

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateChoiceAssignment")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	public void SetChoiceEnabled(bool isEnabled)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetHovered(bool isHovered)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsHovered()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Setup")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AssignChoiceToCategorySlot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void SetupNormalUILabelText(string text, float textSize)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DialogueSequenceFP()
	{
	}
}
