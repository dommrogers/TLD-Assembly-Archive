using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public static KeyCode lastKeycodeUsed;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject[] onLeftBackup;

	public GameObject[] onRightBackup;

	public GameObject[] onUpBackup;

	public GameObject[] onDownBackup;

	public bool startsSelected;

	private UIKeyNavigation onLeftNav;

	private UIKeyNavigation onRightNav;

	private UIKeyNavigation onUpNav;

	private UIKeyNavigation onDownNav;

	private BetterList<UIKeyNavigation> onLeftNavBackup;

	private BetterList<UIKeyNavigation> onRightNavBackup;

	private BetterList<UIKeyNavigation> onUpNavBackup;

	private BetterList<UIKeyNavigation> onDownNavBackup;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected GameObject GetLeft()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private GameObject GetRight()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected GameObject GetUp()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected GameObject GetDown()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	protected GameObject Get(Vector3 myDir, bool horizontal)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	protected virtual void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIKeyNavigation()
	{
	}
}
