// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[AddComponentMenu(MENU_PATH + nameof(PlayAudioDuringPause), DEFAULT_ORDER)]
	public sealed class PlayAudioDuringPause : MonoBehaviour, IPauseListener
	{
		[SerializeField] private AudioSource _audioSource;

		private void OnEnable() { }

		void IPauseListener.Pause()
		{
			enabled = true;
			_audioSource.Play();
		}

		void IPauseListener.Resume()
		{
			enabled = false;
			_audioSource.Stop();
		}
	}
}