// SPDX-License-Identifier: Apache-2.0
// © 2025 Depra <n.melnikov@depra.org>

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(PauseInputPort), DEFAULT_ORDER)]
	public sealed class PauseInputPort : ScenePauseInput
	{
		[SerializeField] private InputActionReference _pauseAction;

		public override event Action PauseTriggered;
		public override event Action ResumeTriggered;

		private void OnEnable()
		{
			_pauseAction.action.Enable();
			_pauseAction.action.performed += OnPausePerformed;
		}

		private void OnDisable()
		{
			_pauseAction.action.Disable();
			_pauseAction.action.performed -= OnPausePerformed;
		}

		private void OnPausePerformed(InputAction.CallbackContext obj)
		{
			if (State.IsPaused)
			{
				ResumeTriggered?.Invoke();
			}
			else
			{
				PauseTriggered?.Invoke();
			}
		}
	}
}