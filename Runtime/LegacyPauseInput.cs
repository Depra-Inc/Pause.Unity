// SPDX-License-Identifier: Apache-2.0
// © 2023-2025 Depra <n.melnikov@depra.org>

using System;
using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(LegacyPauseInput), DEFAULT_ORDER)]
	internal sealed class LegacyPauseInput : ScenePauseInput
	{
		[SerializeField] private string _buttonName = "Cancel";

		public override event Action PauseTriggered;
		public override event Action ResumeTriggered;

		private void Update()
		{
			if (Input.GetButtonDown(_buttonName))
			{
				Toggle();
			}
		}

		private void Toggle()
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