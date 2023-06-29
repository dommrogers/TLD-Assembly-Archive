using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch;

public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
{
	[Serializable]
	private class UserData : IKeyedData<int>
	{
		private int _allowedNpadStyles;

		private int _joyConGripStyle;

		private bool _adjustIMUsForGripStyle;

		private int _handheldActivationMode;

		private bool _assignJoysticksByNpadId;

		private bool _useVibrationThread;

		private NpadSettings_Internal _npadNo1;

		private NpadSettings_Internal _npadNo2;

		private NpadSettings_Internal _npadNo3;

		private NpadSettings_Internal _npadNo4;

		private NpadSettings_Internal _npadNo5;

		private NpadSettings_Internal _npadNo6;

		private NpadSettings_Internal _npadNo7;

		private NpadSettings_Internal _npadNo8;

		private NpadSettings_Internal _npadHandheld;

		private DebugPadSettings_Internal _debugPad;

		private Dictionary<int, object[]> __delegates;

		public int allowedNpadStyles
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int joyConGripStyle
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool adjustIMUsForGripStyle
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int handheldActivationMode
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool assignJoysticksByNpadId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool useVibrationThread
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private NpadSettings_Internal npadNo1
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo2
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo3
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 18)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo4
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 4)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo5
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo6
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 15)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo7
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo8
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadHandheld
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 4)]
			get
			{
				return null;
			}
		}

		public DebugPadSettings_Internal debugPad
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
			get
			{
				return null;
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 27)]
			[CallsUnknownMethods(Count = 101)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return false;
		}

		[CalledBy(Type = typeof(NintendoSwitchInputManager), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public UserData()
		{
		}
	}

	[Serializable]
	private sealed class NpadSettings_Internal : IKeyedData<int>
	{
		private bool _isAllowed;

		private int _rewiredPlayerId;

		private int _joyConAssignmentMode;

		private Dictionary<int, object[]> __delegates;

		private bool isAllowed
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private int rewiredPlayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private int joyConAssignmentMode
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 31)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		internal NpadSettings_Internal(int playerId)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class DebugPadSettings_Internal : IKeyedData<int>
	{
		private bool _enabled;

		private int _rewiredPlayerId;

		private Dictionary<int, object[]> __delegates;

		private int rewiredPlayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private bool enabled
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 21)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal DebugPadSettings_Internal(int playerId)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return false;
		}
	}

	private UserData _userData;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private object Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EInitialize(Platform platform, object configVars)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EDeinitialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public NintendoSwitchInputManager()
	{
	}
}
