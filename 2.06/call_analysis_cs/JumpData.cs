using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.Encryption;
using TLD.Gameplay;
using TLD.SaveState;
using TLD.Serialization;
using UnityEngine;

public class JumpData
{
	public const string EDITOR_FILE_TO_LOAD = "JMPED_FileToLoad";

	public const int DISPLAY_NAME_MAX_LENGTH = 20;

	private string _003Cm_ActiveMissionId_003Ek__BackingField;

	private string _003Cm_ActiveMissionLocId_003Ek__BackingField;

	private GameModeConfig _003CGameModeConfig_003Ek__BackingField;

	public int m_EditorId;

	private string _003Cm_FilePath_003Ek__BackingField;

	private float _003Cm_HoursSurvived_003Ek__BackingField;

	private string _003Cm_Location_003Ek__BackingField;

	private ScreenshotSaveGameFormat _003Cm_Screenshot_003Ek__BackingField;

	private SlotData _003Cm_Slot_003Ek__BackingField;

	public string m_ActiveMissionId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 113)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 269)]
		protected set
		{
		}
	}

	public string m_ActiveMissionLocId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 93)]
		protected set
		{
		}
	}

	public GameModeConfig GameModeConfig
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		protected set
		{
		}
	}

	public string m_FilePath
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		protected set
		{
		}
	}

	public float m_HoursSurvived
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public string m_Location
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 65)]
		protected set
		{
		}
	}

	public ScreenshotSaveGameFormat m_Screenshot
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		protected set
		{
		}
	}

	public SlotData m_Slot
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 21)]
		protected set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected JumpData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(TypeFullName = "System.DateTimeFormat", Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 6)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public string GetTreePath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsStoryMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsUnknownMethods(Count = 1)]
	public void Rename(string name)
	{
	}

	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "Validate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(BaseState), Member = "TryGetData")]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public static JumpData LoadFromFile(string path)
	{
		return null;
	}
}
