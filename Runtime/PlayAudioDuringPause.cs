// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Pause
{
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