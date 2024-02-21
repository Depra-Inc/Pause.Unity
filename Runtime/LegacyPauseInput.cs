// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(LegacyPauseInput), DEFAULT_ORDER)]
	public sealed class LegacyPauseInput : ScenePauseInput
	{
		[SerializeField] private string _buttonName = "Cancel";

		private bool _paused;

		public override event Action Pause;
		public override event Action Resume;

		private void Update()
		{
			if (Input.GetButtonDown(_buttonName))
			{
				Toggle();
			}
		}

		private void Toggle()
		{
			_paused = !_paused;
			if (_paused)
			{
				Pause?.Invoke();
			}
			else
			{
				Resume?.Invoke();
			}
		}
	}
}